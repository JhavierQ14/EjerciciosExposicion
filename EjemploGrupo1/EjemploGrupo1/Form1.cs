using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploGrupo1
{
    public partial class FrmFormulario : Form
    {
        public FrmFormulario()
        {
            InitializeComponent();
        }
        
        public void Insert(string nom)
            {

                List<string> Lista = new List<string>();

                Lista.Add(nom);

                foreach (string ver in Lista)
                {
                      DtgDatosAmostrar.Rows.Add(ver);
                }

                TxtDatos.Text = "";
            }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Insert(TxtDatos.Text);
        }
    }
    }

