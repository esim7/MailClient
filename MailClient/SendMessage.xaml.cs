using Limilabs.Client.SMTP;
using Limilabs.Mail;
using Limilabs.Mail.Headers;
using System;
using System.Collections.Generic;
using System.Net.Mail;
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
    /// Логика взаимодействия для SendMessage.xaml
    /// </summary>
    public partial class SendMessage : Page
    {
        public MainWindow Window;
        public SendMessage(MainWindow window)
        {
            InitializeComponent();
            this.Window = window;
        }

        private void SendMessageClick(object sender, RoutedEventArgs e)
        {
            MailBuilder builder = new MailBuilder();
            builder.From.Add(new MailBox(from_textBox.Text, "Hello"));
            builder.To.Add(new MailBox(to_textBox.Text, "World"));
            builder.Subject = subject_textBox.Text;
            builder.Text = messageText_textBox.Text;

            IMail email = builder.Create();

            using (Smtp smtp = new Smtp())
            {
                smtp.ConnectSSL("smtp.gmail.com");    
                smtp.UseBestLogin("email", "password"); //вставляем email и пароль 

                ISendMessageResult result = smtp.SendMessage(email);
                if (result.Status == SendMessageStatus.Success)
                {
                    MessageBox.Show("Сообщение отправленно!");
                }
                smtp.Close();
            }
        }
    }
}
