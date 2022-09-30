using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenParcial1
{
    public partial class SelecDivisa : Form
    {
        private int y = 45;
        private int x = 17;
        private int con = 0;
        public SelecDivisa()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
            /*for (int i=0;i<=checkDivisa.Items.Count;i++)
            {
                if (checkDivisa.Items[i].Selected == true) {
                    Label temp = new Label();
                    Height = 25;
                    Width = 188;
                    temp.Location = new Point(x, y);
                    y += 35;
                    temp.Name = "lblDivisa" + con.ToString();
                    temp.Text = "";
                    con += 1;
                }
            }*/
            this.Close();

        }
    }
}
