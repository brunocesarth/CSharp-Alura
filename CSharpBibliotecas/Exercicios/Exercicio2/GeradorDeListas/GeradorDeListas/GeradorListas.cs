using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GeradorDeListas
{
    public class GeradorListas
    {
        public void ExportarLista(List<object> Contas)
        {
            if (Contas.Count <= 0)
            {
                Console.WriteLine("... Não existe dados para exportação...");
                Console.ReadKey();
            }
            else
            {
                var contas = new XmlSerializer(typeof(List<object>));
                try
                {
                    string json = JsonConvert.SerializeObject(Contas,
                    Formatting.Indented);
                    try
                    {
                        FileStream files = new FileStream(@"c:\temp\export\contas.json",
                            FileMode.Create);
                        using (StreamWriter streamwriter = new StreamWriter(files))
                        {
                            streamwriter.WriteLine(json);
                        }
                        Console.WriteLine(@"Arquivo salvo em c:\tmp\export\");
                        Console.ReadKey();
                    }
                    catch (Exception excecao)
                    {
                        Console.WriteLine(excecao.Message);
                        Console.ReadKey();
                    }

                    FileStream fs = new FileStream(@"c:\temp\export\contas.xml",
                         FileMode.Create);

                    using (StreamWriter stream = new StreamWriter(fs))
                    {
                        contas.Serialize(stream, Contas);
                    }
                    Console.WriteLine(@"Arquivo salvo em c:\tmp\export\");
                    Console.ReadKey();
                }
                catch (Exception excecao)
                {
                    Console.WriteLine(excecao.Message);
                    Console.ReadKey();
                }
            }
        }
    }
}
