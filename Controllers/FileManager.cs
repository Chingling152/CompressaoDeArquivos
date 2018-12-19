using System.IO;
using System.IO.Compression;

namespace CompressaoDeArquivos.Controllers
{
    public static class FileManager
    {
        public static string Arquivo;
        public static string Diretorio = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);

        public static void Comprimir(CompressionLevel levelCompressao)
        {
            throw new System.NotImplementedException();
        }

        public static string VerificarCaminho(string caminho)
        {
            if(Directory.Exists(caminho)){
                return caminho;
            }else{
                return "Pasta não encontrada";
            }
        }

        public static string VerificarArquivo(string arquivo){
            throw new System.NotImplementedException();
        }
    }
}