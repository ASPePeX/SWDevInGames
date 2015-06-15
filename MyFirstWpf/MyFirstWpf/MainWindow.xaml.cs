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

namespace MyFirstWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int clicks;

        public MainWindow()
        {
            InitializeComponent();
            clicks = 0;
            MyButton.Click += delegate(object sender, RoutedEventArgs routedEventArgs)
            {
                clicks++;
                MyTextBox.Text = "Butten " + clicks;
            };

            this.MouseMove += delegate(object sender, MouseEventArgs args)
            {
                Point pt = args.GetPosition(this);
                MyTextBox.Text = "Maus bei " + pt;
            };
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            clicks++;
            MyTextBox.Text = "Butten " + clicks;
        }
    }
}
