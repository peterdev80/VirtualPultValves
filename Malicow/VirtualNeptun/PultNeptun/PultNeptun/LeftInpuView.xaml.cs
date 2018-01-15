using AVIAKOM;
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
using VirtualPultValves.Views;

namespace PultNeptun
{
    /// <summary>
    /// Логика взаимодействия для LeftInpuView.xaml
    /// </summary>
    public partial class LeftInpuView : UserControl
    {
      

        public LeftInpuView()
        {
            InitializeComponent();
            //определяем DPI Монитора
          
        }
        private void PultGlassButton_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void PultGlassButton_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {

           

        }
        private InpuPresenter InPUControl;
        private InPUWin32View com;
        private void WinPult_Loaded(object sender, RoutedEventArgs e)

        {
           // WinPult.Content = new InpuFailed();// new InpuPresenter(600, 800, 1, new InpuFailed(), new InpuFailed());

           /* com = WinPult.Content as InPUWin32View;
            if (com != null)
            {
                InPUControl = com.InPUControl;
             
            }*/
        }
    }
}
