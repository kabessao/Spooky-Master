using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Spooky
{
    class Config
    {
        public int Selecao { get; set; }

        public bool EsconderArquivos { get; set; }
        public string Nome { get; set; }

        public Config(string nome)
        {
            this.Nome = nome;
            if (!File.Exists(nome))
            {
                var file = File.Create(nome);
                file.Close();
                var writer = new StreamWriter(nome);
                writer.WriteLine("0,0,0,0,0");
                writer.Close();
                
            }
            var reader = new StreamReader(nome);

            List<string> lista = reader.ReadToEnd().Split(',').ToList<string>();

            int.TryParse(lista[0], out int selecao);
            int.TryParse(lista[1], out int escondertodos);

            this.Selecao = selecao;

            if (escondertodos == 1)
                this.EsconderArquivos = true;
            else
                this.EsconderArquivos = false;
           
            reader.Close();

        }

        public void Salvar()
        {
            int escondertodos;
            var writer = new StreamWriter(Nome);
            if (this.EsconderArquivos)
                escondertodos = 1;
            else
                escondertodos = 0;



            writer.WriteLine(this.Selecao + "," + escondertodos);
            writer.Close();
        }


    }
}
