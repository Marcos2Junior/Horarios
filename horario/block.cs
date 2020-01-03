using System.IO;

namespace horario
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
                return false;
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
                return false;
            }
            return true;
        }
    }
}
