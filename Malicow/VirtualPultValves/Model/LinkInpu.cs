using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Threading;
using System.Xml;
using ValueModel.BaseModel;
namespace VirtualPultValves.Model
{
    public class LinkInpu
    {
        const int LINVAR = 6;
        const int LOUTVAR = 7;


        String s_ipadress;
        int udpSendtoModel;
        int udpRecivetoKlapan;


        private static volatile LinkInpu instance;



        public static LinkInpu Instance
        {
            get
            {
                if (instance == null)
                    instance = new LinkInpu();

                return instance;
            }
        }



        private BitVector32[] dins = new BitVector32[LOUTVAR];
        private void sendBuf()
        {
            var bs = new UInt32[LOUTVAR];


            for (var i = 0; i < LOUTVAR; i++)
                bs[i] = (uint)dins[i].Data;
            var ms = new MemoryStream();
            var wr = new BinaryWriter(ms);

            wr.Write((UInt32)2003); //запись клапонов
            foreach (var bb in bs)
                wr.Write(bb);

            byte[] sendbuf = ms.ToArray();

            UdpClient udp = new UdpClient();

            // Указываем адрес отправки сообщения
            IPAddress ipaddress = IPAddress.Parse(s_ipadress);
            IPEndPoint ipendpoint = new IPEndPoint(ipaddress, udpSendtoModel);

            // Формирование оправляемого сообщения и его отправка.

            int sended = udp.Send(sendbuf, sendbuf.Length, ipendpoint);


            // После окончания попытки отправки закрываем UDP соединение,
            // и освобождаем занятые объектом UdpClient ресурсы.
            udp.Close();

        }
        public void SetSendVar(bool vall, int poss, int valnum)
        {
            for (var i = 0; i < dins.Length; i++)
                dins[i] = new BitVector32();
            dins[valnum][1 << poss] = vall;
            sendBuf();



        }
        public void SetSendVar(int vall, int valnum)
        {
            for (var i = 0; i < dins.Length; i++)
                dins[i] = new BitVector32();
            dins[valnum][BitVector32.CreateSection(100)] = vall;

            sendBuf();

        }

        private void findFile()
        {
            if (File.Exists("initIO.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("initIO.xml");
                foreach (XmlNode node in doc.DocumentElement)
                {

                    s_ipadress = node["ip"].InnerText;
                    udpSendtoModel = int.Parse(node["Send_to_Model"].InnerText);
                    udpRecivetoKlapan = int.Parse(node["Recive_to_Klapan"].InnerText);

                }
            }
            else
            {
                MessageBox.Show("Файл initIO.xml не найден");
            }
        }

        Thread rec = null;
        UdpClient udp = new UdpClient();
        bool stopReceive = false;

        void StartRecive()
        {
            ThreadPool.QueueUserWorkItem(Receive);


        }

        void Receive(Object stateInfo)
        {
            var b = new UInt32[LINVAR];
            try
            {
                // MessageBox.Show("Start Recive");
                // Перед созданием нового объекта закрываем старый
                // для освобождения занятых ресурсов.
                if (udp != null) udp.Close();

                udp = new UdpClient(udpRecivetoKlapan);

                while (true)
                {

                    IPEndPoint ipendpoint = null;
                    byte[] message = udp.Receive(ref ipendpoint);
                    if (message.GetLength(0) < LINVAR * 4)
                        MessageBox.Show("--- " + message.GetLength(0).ToString());
                    //  MessageBox.Show(BitConverter.ToUInt32(message, 0).ToString());
                    if (BitConverter.ToUInt32(message, 0) == 2002)
                    {


                        for (int i = 1; i < LINVAR + 1; i++)
                        {

                            b[i - 1] = BitConverter.ToUInt32(message, (i) * 4);
                        }
                        var repos = ModelVariableRepository.Instance;

                        for (int i = 0; i < 3; i++)
                        {
                            var r = repos.BitValues[i];
                            r.Dispatcher.Invoke(new Action(() =>
                            {
                                r.VaRStateInt = (Int32)b[i];
                            }));//

                        }
                        for (int i = 0; i < 3; i++)
                        // repos.IntValues[i].VaRStateInt = (Int32)b[i + 3];
                        {
                            var r = repos.IntValues[i];
                            r.Dispatcher.Invoke(new Action(() => { r.VaRStateInt = (Int32)b[i + 3]; }));

                        }
                    }


                    // Если дана команда остановить поток, останавливаем бесконечный цикл.
                    if (stopReceive == true) break;
                }

                udp.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Main EROR" + e.Message);
            }
        }


        // Функция безопасной остановки дополнительного потока
        void StopReceive(Object stateInfo)
        {
            // Останавливаем цикл в дополнительном потоке
            stopReceive = true;

            // Принудительно закрываем объект класса UdpClient 
            if (udp != null) udp.Close();

            // Для корректного завершения дополнительного потока
            // подключаем его к основному потоку.
            if (rec != null) rec.Join();
        }
        public LinkInpu()
        {
            findFile();

            StartRecive();


        }

    }
}
