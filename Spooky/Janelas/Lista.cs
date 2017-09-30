using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Spooky
{
    public partial class Lista : Form
    {
        
        
        
        public Lista()
        {
            InitializeComponent();
        }

        private void btnChecar_Click(object sender, EventArgs e)
        {
           
        }

        private void Lista_Load(object sender, EventArgs e)
        {
            Config config = new Config(Diretorios.Preferencias);
            chkArquivos.Checked = config.EsconderArquivos;
            var reader = new StreamReader(Diretorios.Lista);
            txtLista.Text = reader.ReadToEnd();
            reader.Close();

        }

        private void Lista_FormClosing(object sender, FormClosingEventArgs e)
        {
            var reader = new StreamReader(Diretorios.Lista);
            string texto = reader.ReadToEnd();
            reader.Close();
            bool teste = true;
            string error = "";

            if (!(texto.Length == 0))
            {
                foreach (var item in texto.Split('\n'))
                {
                    if (!File.Exists(item.Replace('\r', ' ')))
                    {
                        if (!Directory.Exists(item.Replace('\r', ' ')))
                        {
                            teste = false;
                            error += item + ", ";
                        }
                    }
                }
            }


            if (teste)
            {
                if (!texto.Equals(txtLista.Text))
                {
                    if (MessageBox.Show("Deseja salvar?",
                    "Salvar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        var file = new StreamWriter(Diretorios.Lista);
                        file.Write(txtLista.Text);
                        file.Close();

                    }
                }
            }
            else            
                MessageBox.Show("os items {" + error + "} não existem");








            Config config = new Config(Diretorios.Preferencias)
            {
                EsconderArquivos = chkArquivos.Checked
            };

            config.Salvar();

           
        }
    }
}
