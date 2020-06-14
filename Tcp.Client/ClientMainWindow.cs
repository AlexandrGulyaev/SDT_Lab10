using System;
using System.Windows.Forms;
using SomeProject.Library.Client;
using SomeProject.Library;

namespace SomeProject.TcpClient
{
    public partial class ClientMainWindow : Form
    {
        /// <summary>
        /// Инициализация окна клиента
        /// </summary>
        public ClientMainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработка нажатия на кнопку "Отправить сообщение"
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void OnMsgBtnClick(object sender, EventArgs e)
        {
            Client client = new Client();
            Result res = client.SendMessageToServer(textBox.Text).Result;
            if(res == Result.OK)
            {
                textBox.Text = "";
                labelRes.Text = "Message was sent succefully!";
            }
            else
            {
                labelRes.Text = "Cannot send the message to the server.";
            }
            timer.Interval = 2000;
            timer.Start();
        }
        /// <summary>
        /// Очистка по истечении времени
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTimerTick(object sender, EventArgs e)
        {
            labelRes.Text = "";
            timer.Stop();
        }

        /// <summary>
        /// Обработка нажатия на кнопку "Отправить файл"
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void OnFileBtnClick(object sender, EventArgs e)
        {
            Client client = new Client();
            OperationResult res;
            string path = SelectFile();

            if (path != null) res = client.SendFileToServer(path);
            else return;

            labelRes.Text = res.Message;

            timer.Interval = 2000;
            timer.Start();
        }

        /// <summary>
        /// Выбор файла
        /// </summary>
        /// <returns>Путь к файлу</returns>
        private string SelectFile()
        {
            using (OpenFileDialog OFileDialog = new OpenFileDialog())
            {
                if (OFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    return OFileDialog.FileName;
                }
                else
                {
                    labelRes.Text = "Неверный путь к файлу";
                    timer.Interval = 2000;
                    timer.Start();
                    return null;
                }
            }
        }
    }
}
