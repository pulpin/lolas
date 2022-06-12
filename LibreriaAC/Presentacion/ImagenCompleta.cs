using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class ImagenCompleta : Form
    {
        public ImagenCompleta()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }
        public void PonerImagen(Image ima)
        {
            pictureBox1.Image = ima;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }
    }
}
