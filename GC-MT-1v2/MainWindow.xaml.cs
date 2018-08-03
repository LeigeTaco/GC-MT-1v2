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

namespace GC_MT_1v2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {

            string temp = "What about the Droid attack on the Wookies?";        //Streamreader to here.
            InitializeComponent();
            WindowHeader.Instance.Header = temp;

        }

        void button_Click(object sender, RoutedEventArgs e)
        {
            // Show message box when button is clicked
            MessageBox.Show("He's right, it's a system we can't afford to lose.");

        }

    }

    public class Program
    {

        public static void OpenConsole()
        {

            Console.ReadLine();

        }

    }

    public class WindowHeader : DependencyObject
    {
        public static readonly DependencyProperty HeaderProperty =
            DependencyProperty.Register("Header", typeof(string),
            typeof(WindowHeader), new UIPropertyMetadata("My App v2.5"));
        /// <summary>
        /// Sets the header message for the Datawindow
        /// </summary>
        public string Header
        {
            get { return (string)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        public static WindowHeader Instance { get; private set; }

        static WindowHeader()
        {
            Instance = new WindowHeader();
        }
    }

}
