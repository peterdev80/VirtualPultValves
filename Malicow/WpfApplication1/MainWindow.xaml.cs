using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;


using VirtualPultValves.Model;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
         /*  var dc = VariablesDataContext.GetNamedContext("mnemo");
            dc.VariablesChannelName = "VarNeptun";
            dc.Manager = Manager.GetAPI("mnemo", Guid.Parse("B7BC704A-3000-4B17-8AD4-823EF6A4D892"));
          */

            var e=LinkInpu.Instance;


            InitializeComponent();
            
        }

        private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void button1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            
            Debug.WriteLine("a");

        }

        private void button1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void button1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("p");

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            

        }
    }
}
