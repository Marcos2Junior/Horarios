using System.IO;

namespace ControlePessoal
{
    public class block
    {
        public bool DesBloquearPasta(string arquivo)
        {
            arquivo += ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}";
            DirectoryInfo PastaInfo = new DirectoryInfo(arquivo);
            string caminhoArquivo = PastaInfo.FullName;
            string nomeArquivo = caminhoArquivo.ToString().Replace(".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}", "");
            try
            {
                Directory.Move(caminhoArquivo, nomeArquivo);
            }
            catch
            {
                DirectoryInfo dInfo = new DirectoryInfo(arquivo.Replace(".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}", ""));
                string caminhoArquivo1 = dInfo.FullName;
                string nomeArquivo2 = caminhoArquivo1.ToString() + ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}";
                try
                {
                    Directory.Move(caminhoArquivo1.ToString(), nomeArquivo2.ToString());

                    try
                    {
                        Directory.Move(caminhoArquivo, nomeArquivo);
                    }
                    catch
                    {
                        return false;
                    }
                }
                catch
                {
                    return false;
                }

                return true;
            }
            return true;

        }

        public bool BloquearPasta(string arquivo)
        {
            DirectoryInfo dInfo = new DirectoryInfo(arquivo);
            string caminhoArquivo = dInfo.FullName;
            string nomeArquivo = caminhoArquivo.ToString() + ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}";
            try
            {
                Directory.Move(caminhoArquivo.ToString(), nomeArquivo.ToString());
            }
            catch
            {
                arquivo += ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}";
                DirectoryInfo PastaInfo = new DirectoryInfo(arquivo);
                string caminhoArquivo1 = PastaInfo.FullName;
                string nomeArquivo2 = caminhoArquivo1.ToString().Replace(".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}", "");
                try
                {
                    Directory.Move(caminhoArquivo1, nomeArquivo2);

                    DirectoryInfo dInfo5 = new DirectoryInfo(arquivo);
                    string caminhoArquivo5 = dInfo.FullName;
                    string nomeArquivo5 = caminhoArquivo5.ToString() + ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}";
                    try
                    {
                        Directory.Move(caminhoArquivo5.ToString(), nomeArquivo5.ToString());
                    }
                    catch
                    {
                        return false;
                    }
                }
                catch
                {
                    return false;
                }
            }

            return true;
        }
    }
}
