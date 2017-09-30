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
using System.Diagnostics;

namespace Spooky
{
    public partial class JanelaPrincipal : Form
    {
        
        

        
        public JanelaPrincipal()
        {


            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChecarLista();

            VerOpcao();
        }

        private void ChecarLista()
        {
            try
            {
                if (!File.Exists(Diretorios.Lista))
                {


                    var file = File.Create(Diretorios.Lista);
                    file.Close();
                }
                Config config = new Config(Diretorios.Preferencias);
                trcOpcao.Value = config.Selecao;
            }
            catch (Exception jao)
            {
                Erro(jao);

            }
        }

        private static void Erro(Exception jao)
        {
            MessageBox.Show("Deu merda:\n" + jao.Message , "Mas Que Merda!");
            
        }

        private void VerOpcao()
        {
            switch (trcOpcao.Value)
            {
                case (int)Opcao.EsconderTudo:
                    lblOpcao.Text = "Esconder Tudo";
                    break;
                case (int)Opcao.ArquivosNaLista:
                    lblOpcao.Text = "Apenas arquivos na lista";
                    break;
                case (int)Opcao.MostrarTudo:
                    lblOpcao.Text = "Mostrar tudo";
                    break;
                default:
                    break;
            }
            
        }

        private void trcOpcao_Scroll(object sender, EventArgs e)
        {
            VerOpcao();
        }

        enum Opcao
        {
            MostrarTudo,
            ArquivosNaLista,
            EsconderTudo
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            switch (trcOpcao.Value)
            {
                case (int)Opcao.EsconderTudo:
                    spooky.EsconderTudo();
                    break;
                case (int)Opcao.ArquivosNaLista:
                    Config config = new Config(Diretorios.Preferencias);
                    spooky.EsconderAlguns(GetArquivo(), config.EsconderArquivos);
                    break;
                case (int)Opcao.MostrarTudo:
                    spooky.MostrarTudo();
                    break;
                default:
                    break;

            }


            this.Enabled = true;
        }

        static public string[] GetArquivo()
        {
            var file = new StreamReader(Diretorios.Lista);
            string config = file.ReadToEnd();
            file.Close();
            return config.Split('\n');
        } 

        private void button4_Click(object sender, EventArgs e)
        {
            Lista lista = new Lista();
            this.Hide();
            lista.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Diretorios.LogPath))
            {

                MessageBox.Show("Pasta de log não encontrado",
                    "Aviso");
                Directory.CreateDirectory(Diretorios.LogPath);
                Explorer();
                MessageBox.Show("pasta de logs criada com sucesso!",
                    "Confirmação");

            }
            else
            {
                this.Hide();
                Explorer();
                this.Show();
            }

        }

        private static void Explorer()
        {
            var explorer = new Process();
            explorer.StartInfo.FileName = "explorer.exe";
            explorer.StartInfo.Arguments = Diretorios.LogPath;
            explorer.Start();
            explorer.WaitForExit();
        }

        private void JanelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void JanelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                var config = new Config(Diretorios.Preferencias)
                {
                    Selecao = trcOpcao.Value
                };
                config.Salvar();
            }
            catch (Exception jao)
            {

                Erro(jao);
            }
        }

        
    }

}
