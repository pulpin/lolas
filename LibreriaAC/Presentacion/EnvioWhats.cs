using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WhatsAppApi;

namespace Presentacion
{
    public partial class EnvioWhats : Form
    {
        public EnvioWhats()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from = "+5492966645889";
            string to = txtto.Text;
            string msg = txtmessage.Text;
            WhatsApp wa = new WhatsApp(from, "d0c6b7de46763e7e092ddbf9fa033da3", "Prueba",true,true);
            wa.OnConnectSuccess += () =>
            {
                MessageBox.Show("conectando a whatsapp");
                wa.OnLoginSuccess += (phone, data) =>
                {
                    wa.SendMessage(to, msg);
                    MessageBox.Show("enviando mensaje");
                };
                wa.OnLoginFailed += (data) =>
                {
                    MessageBox.Show("Falló el envio en el loguin : {0}", data);
                };
                wa.Login();
            };

            wa.OnConnectFailed += (ex) =>
            {
                MessageBox.Show("Falló la conexión...");
            };
            wa.Connect();
        }
    }
}
