using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LogicaNegocios;

namespace Presentacion
{
    public partial class Login : Form
    {
       
        private int _ideusu;
        Usuarios usu = new Usuarios();
        public Login()
        {
            InitializeComponent();
        }

        public Login(String usu, String con)
        {
          //  InitializeComponent();
            seteousuario(usu, con);
            
        }
        // set y get de ide de usuarios
        public int ideusu
        {
            set { this._ideusu = value; }
            get { return this._ideusu; }
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            seteousuario(LUEusuario.Text, txtcontraseña.Text);
        }

        public void seteousuario(String usu, String con) {
            SeteoUsuario se = new SeteoUsuario();

            if (se.tryLogin(usu, con) == true)
            {
                se.Usuide = Globales.gbUsuide;
                se.ColorElegido = Convert.ToString(colorEdit1.Color.Name);
                int cambiarcolor = se.spVerificarColorElegidoLogueo();
                if (cambiarcolor == 0)
                {
                this.Hide();
                Principal pri = new Principal();
                pri.seteoUsuario(LogicaNegocios.Globales.gbUsuario, LogicaNegocios.Globales.gbUsuide, LogicaNegocios.Globales.gbLocalidad, LogicaNegocios.Globales.gbLocalide, LogicaNegocios.Globales.gbtipousuario);
                
                panelColor.BackColor = colorEdit1.Color;
                Globales.colorfondo = colorEdit1.Color;
                    
                    se.Usuide = LogicaNegocios.Globales.gbUsuide;
                    se.Colorfondo = Convert.ToString(colorEdit1.Color.Name);
                    se.ModificarColorFondo();
                    pri.cambiarfondo();
                    pri.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Debe seleccionar otro COLOR para el usuario");
                }
                
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }



        private void txtcontraseña_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnIngreso.Focus();
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void colorEdit1_EditValueChanged(object sender, EventArgs e)
        {
            /*usu.Colorfondo = Convert.ToString(colorEdit1.Color);
            usu.Usuide = Globales.gbUsuide;
            int resu = usu.spVerificarColorElegidoLogueo();
            if (resu == 0)
            {*/



            panelColor.BackColor = colorEdit1.Color;
                Globales.colorfondo = colorEdit1.Color;
               /* }
                else
                {
                MessageBox.Show("Debe seleccionar otro COLOR para el USUARIO");
                }
          */
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Usuarios usu = new Usuarios();

            LUEusuario.Properties.DisplayMember = "USU_NOMBRE";
            LUEusuario.Properties.ValueMember = "USU_COLOR";
            LUEusuario.Properties.DataSource = usu.Mostrar_Datos_Usuarios();
            LUEusuario.Properties.PopulateColumns();
            LUEusuario.Properties.Columns[1].Visible = false;
        }



        private void txtusuario_EditValueChanged(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            
        }

        private void LUEusuario_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            
        if (e.KeyCode == Keys.Enter)
            {
                this.txtcontraseña.Focus();
            }
        }

        private void LUEusuario_EditValueChanged(object sender, EventArgs e)
        {
            colorEdit1.Color = Color.FromName(Convert.ToString(LUEusuario.EditValue));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}

