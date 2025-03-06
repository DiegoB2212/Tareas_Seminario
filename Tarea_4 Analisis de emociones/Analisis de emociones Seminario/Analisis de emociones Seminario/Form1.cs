using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analisis_de_emociones_Seminario
{
    public partial class Form1 : Form
    {
        Feel_Analizer fl_analizer = new Feel_Analizer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Message_Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            string msg = Message_Input.Text;
            string rsp = string.Empty;

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (msg == null || msg == string.Empty)
                {
                    MessageBox.Show(
                        "Casilla de texto vacia, intente de nuevo",
                        "ERROR",
                        MessageBoxButtons.AbortRetryIgnore,
                        MessageBoxIcon.Error
                    );
                    return;
                }
                rsp = fl_analizer.Run(msg);
                switch (rsp)
                {
                    case "positivo": pictureBox1.Image = Properties.Resources.positivo; break;
                    case "negativo": pictureBox1.Image = Properties.Resources.triste; break;
                    default: pictureBox1.Image = Properties.Resources.neutral; break;
                }
            }
        }
    }
}
