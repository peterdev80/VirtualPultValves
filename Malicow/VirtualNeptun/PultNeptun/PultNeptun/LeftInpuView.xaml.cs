using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace PultNeptun
{
    /// <summary>
    /// Логика взаимодействия для LeftInpuView.xaml
    /// </summary>
    public partial class LeftInpuView : UserControl
    {
        int dpiX;//дпи текущкго монитора
        public const int mmWidth=210; //Штрина ИнПУ
        public const int mmHeight = 158;//Высота ИнПУ

        public LeftInpuView()
        {
            InitializeComponent();
            //определяем DPI Монитора
            var dpiXProperty = typeof(SystemParameters).GetProperty("DpiX", BindingFlags.NonPublic | BindingFlags.Static);
            dpiX = (int)dpiXProperty.GetValue(null, null);
        }
        private void PultGlassButton_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void PultGlassButton_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {

           

        }
    }
}
