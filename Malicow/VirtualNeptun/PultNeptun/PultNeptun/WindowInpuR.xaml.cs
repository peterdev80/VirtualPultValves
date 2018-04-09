﻿using AVIAKOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VirtualPultValves.Views;

namespace PultNeptun
{
    /// <summary>
    /// Логика взаимодействия для WindowInpuR.xaml
    /// </summary>
    public partial class WindowInpuR : UserControl
    {

        private InpuPresenter InPUControl;
        private InPUWin32View com;
        private static int NumInpu=2;
        private VirtualPultValves.ViewModel.ViewModel_InPU vminpu;
        public WindowInpuR()
        {
            InitializeComponent();
            vminpu = roo.DataContext as VirtualPultValves.ViewModel.ViewModel_InPU;
        }
        #region Commanda BtnClick

        //Команда для кнопок 

        public static RoutedCommand BtnCmd = new RoutedCommand();

        private void BtnCmdExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            var par = Int32.Parse(e.Parameter.ToString());
            InPUControl.PressNeptKey(NumInpu, par);
        }

        private void BtnCmdCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        #endregion

        private void PultGlassButton_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.CommandParameter.ToString() == "1")
                vminpu.CmdVKL_REZ_BATAR_DOWN.Execute(1);
            if (btn.CommandParameter.ToString() == "2")
                vminpu.CmdOTBOI_ZVUKA_DOWN.Execute(1);

            if (btn.CommandParameter.ToString() == "3")
            {
                if (vminpu.RMNum == 1) vminpu.CmdVKLInpu1.Execute(1);
                if (vminpu.RMNum == 2) vminpu.CmdVKLInpu2.Execute(1);
            }

            if (btn.CommandParameter.ToString() == "4")
            {
                // MessageBox.Show("->");
                if (vminpu.RMNum == 1)
                {
                    // MessageBox.Show("lll");
                    vminpu.CmdOTKLInpu1.Execute(1);
                }

                if (vminpu.RMNum == 2) vminpu.CmdOTKLInpu2.Execute(1);
            }
        }

        private void PultGlassButton_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {

            Button btn = (Button)sender;
            if (btn.CommandParameter.ToString() == "1")
                vminpu.CmdVKL_REZ_BATAR_DOWN.Execute(0);
            if (btn.CommandParameter.ToString() == "2")
                vminpu.CmdOTBOI_ZVUKA_DOWN.Execute(0);

            if (btn.CommandParameter.ToString() == "3")
            {
                if (NumInpu == 1) vminpu.CmdVKLInpu1.Execute(0);
                if (NumInpu == 2) vminpu.CmdVKLInpu2.Execute(0);
            }
            if (btn.CommandParameter.ToString() == "4")
            {
                if (NumInpu == 1) vminpu.CmdOTKLInpu1.Execute(0);
                if (NumInpu == 2) vminpu.CmdOTKLInpu2.Execute(0);
            }

        }
    }
}
}
