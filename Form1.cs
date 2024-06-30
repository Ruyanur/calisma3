using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace cilentform
{
    public partial class Form1 : Form
    {
        private ClientDevice client;

        public Form1()
        {
            InitializeComponent();
            DisableControls();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklenirken gereken işlemler
            client = new ClientDevice("server_ip_address", 1234, "client_id");
            client.Start();
            SetClient(client);
        }

        public void SetClient(ClientDevice client)
        {
            this.client = client;
        }

        public void EnableControls()
        {
            txtMessage.Enabled = true;
            btnSendMessage.Enabled = true;
            btnRequestSession.Enabled = false;
            txtSessionTime.Enabled = false;
        }

        public void DisableControls()
        {
            txtMessage.Enabled = false;
            btnSendMessage.Enabled = false;
            btnRequestSession.Enabled = true;
            txtSessionTime.Enabled = true;
        }

        public void UpdatePermission(Permission permission)
        {
            lblPermission.Text = $"Permission: {permission}";
        }

        public void AddMessageToLog(string message)
        {
            lstMessageLog.Items.Add(message);
        }

        private void btnRequestSession_Click(object sender, EventArgs e)
        {
            int sessionTime;
            if (int.TryParse(txtSessionTime.Text, out sessionTime))
            {
                client.RequestSession(sessionTime);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir oturum süresi girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                string message = txtMessage.Text;
                client.SendMessage(message);
                txtMessage.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen bir mesaj girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class ClientDevice
    {
        private TcpClient client;
        private NetworkStream stream;
        private string clientId;

        public ClientDevice(string serverIpAddress, int serverPort, string clientId)
        {
            client = new TcpClient(serverIpAddress, serverPort);
            stream = client.GetStream();
            this.clientId = clientId;
        }

        public void Start()
        {
            Thread receiveThread = new Thread(ReceiveMessages);
            receiveThread.Start();
        }

        private void ReceiveMessages()
        {
            byte[] buffer = new byte[1024];
            int bytesRead;
            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                var message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                // Gelen mesajı işleme kodu buraya gelecek
                // Örneğin:
                // Form1.AddMessageToLog(message);
            }
        }

        public void SendMessage(string message)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(message);
            stream.Write(buffer, 0, buffer.Length);
        }

        public void RequestSession(int sessionTime)
        {
            string requestMessage = $"REQUEST|{clientId}|{sessionTime}";
            byte[] buffer = Encoding.ASCII.GetBytes(requestMessage);
            stream.Write(buffer, 0, buffer.Length);
        }
    }

    public enum Permission
    {
        None,
        Basic,
        Admin,
        SuperAdmin
    }
}
