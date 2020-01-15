using Limilabs.Mail;
using System;
using System.Collections.Generic;
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

namespace MailClient
{
    /// <summary>
    /// Логика взаимодействия для HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Page
    {
        public List<IMail> Messages { get; set; }
        public MainWindow Window;
        public HomeWindow(MainWindow window)
        {
            InitializeComponent();
            this.Window = window;
            Messages = new List<IMail>();
            Messages = Window.Messages;
            lvItems.ItemsSource = Messages;
        }

        private void SendMessageClick(object sender, RoutedEventArgs e)
        {
            Window.frame.Navigate(new SendMessage(Window));
        }
    }
}
