
using Limilabs.Client.IMAP;
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
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        public MainWindow Window;
        public Authorization(MainWindow window)
        {
            InitializeComponent();
            this.Window = window;
        }

        private void GoButton(object sender, RoutedEventArgs e)
        {
            using (Imap imap = new Imap())
            {
                imap.ConnectSSL("imap.gmail.com");

                imap.Login(email_textBox.Text, password_passwordBox.Password);
                imap.SelectInbox();
                List<long> uids = imap.Search(Flag.Unseen);
                foreach (long uid in uids)
                {
                    IMail email = new MailBuilder()
            .CreateFromEml(imap.GetMessageByUID(uid));
                    Window.Messages.Add(email);
                }

                imap.Close();
            }

            Window.frame.Navigate(new HomeWindow(Window));
        }
    }
}
