using System;
using System.IO.Compression;
using CompressaoDeArquivos.Controllers;

namespace CompressaoArquivos.View
{
    public static class Menu
    {
        /// <summary>
        /// Classe responsável por mostrar um menu básico, comprimir e descomprimir!  
        /// Redireciona o usuario para Menu.PrimarioEscolhas
        /// </summary>
        public static void Primario () {
            Console.Clear();
            Console.WriteLine("Opções");
            Console.WriteLine("1. Comprimir");
            Console.WriteLine("2. Descomprimir");
            Console.WriteLine("0. Sair");
            PrimarioEscolhas();
        }
        /// <summary>
        /// Menu onde o usuario define o que deseja fazer
        /// </summary>
        private static void PrimarioEscolhas(){
            int opcao;
            do{
                int.TryParse(Console.ReadLine(),out opcao);

                switch (opcao)
                {   
                    //Caso o usuario queira comprimir pasta
                    case 1:
                        Console.Clear();
                        //Pega o caminho que o usuário inseriu!
                        Console.WriteLine("Digite o endereço onde está a pasta que deseja comprimir!");
                        string arquivo = FileManager.VerificarCaminho(Console.ReadLine());

                        if(arquivo != "Pasta não encontrada"){
                            FileManager.Arquivo = arquivo;
                            Menu.Compressao();
                        }else{
                            Console.WriteLine($"O caminho inserido ({arquivo}) inválido!");
                        }
                        break;
                    case 2://caso o usuario queira descompactar
                        Console.Clear();
                        arquivo = FileManager.VerificarArquivo(Console.ReadLine());
                        if(arquivo != "Pasta não encontrada"){
                            FileManager.Arquivo = arquivo;
                            Menu.Compressao();
                        }else{
                            Console.WriteLine($"O caminho inserido ({arquivo}) inválido!");
                        }
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Obrigada por usar o programa!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }while(opcao != 0);
        }

        /// <summary>
        /// Mostra opções referentes ao nível de compressão
        /// </summary>
        private static void Compressao () {
            Console.Clear();
            Console.WriteLine("Você deseja uma:");
            Console.WriteLine("1. Compactação rápida");
            Console.WriteLine("2. Compactação otimizada");
            Console.WriteLine("3. Não compactar");
        }
        /// <summary>
        /// Menu onde o usuario define o nivel de compressao
        /// </summary>
        private static void CompressaoEscolhas(){
            int opcao;

            do{
                int.TryParse(Console.ReadLine(),out opcao);

                switch (opcao){
                    case 1: 
                        FileManager.Comprimir(CompressionLevel.Fastest);
                        break;
                    case 2: 
                        FileManager.Comprimir(CompressionLevel.Optimal);
                        break;
                    case 3: 
                        FileManager.Comprimir(CompressionLevel.Optimal);
                        break;
                    default: 
                        Console.WriteLine("Opção inválida!");
                        break;          
                    }
            }while(opcao != 0);
        }
    }
}