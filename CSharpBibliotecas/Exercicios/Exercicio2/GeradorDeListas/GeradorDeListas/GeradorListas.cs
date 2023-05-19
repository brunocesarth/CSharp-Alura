using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GeradorDeListas
{

    public static class GeradorListas<T> where T : class
    {

        public static void SalvarDados(string path, FormatoArquivos formato, List<T> dados)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new Exception("O caminho do arquivo não informado");
            }
            if (formato != FormatoArquivos.Xml)
            {
                if (formato != FormatoArquivos.Json)
                    throw new Exception("Formato de arquivo não encontrado.");
            }
            ExportarDados(path, formato, dados);
        }

        private static void ExportarDados(string path, GeradorListas<T>.FormatoArquivos formato, List<T> dados)
        {
            if (formato != FormatoArquivos.Xml)
            {
                var serializar = new XmlSerializer(typeof(List<T>));
                try
                {
                    FileStream fs = new FileStream(path + "\\dados.xml", FileMode.Create);
                    using (StreamWriter streamWriter = new StreamWriter(fs))
                    {
                        serializar.Serialize(streamWriter, dados);
                    }
                    Console.WriteLine($"Arquivo salvo em {path}");
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            if (formato != FormatoArquivos.Json)
            {
                string json = JsonConvert.SerializeObject(dados, Formatting.Indented);
                try
                {
                    FileStream fs = new FileStream(path + "\\dados.json", FileMode.Create);
                    using (StreamWriter streamWriter = new StreamWriter(fs))
                    {
                        streamWriter.WriteLine(json);
                    }
                    Console.WriteLine($"Arquivo salvo em {path}");
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public enum FormatoArquivos
        {
            Xml = 1,
            Json = 2
        }
    }
}
