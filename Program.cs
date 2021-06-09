using System;
using DIOCrud.Classes;

namespace DIOCrud
{
    class Program
    {
        static SerieRepository repository = new SerieRepository();
        static bool newlyAdd = false;

        static void Main(string[] args)
        {
            string input = "";
            while (input != "X") 
            {
                input = AskInput();
                switch (input) 
                {
                    case "1":
                        ListSerie();
                        break;

                    case "2":
                        newlyAdd = true;
                        AddSerie(0);
                        break;

                    case "3":
                        DeleteSerie();
                        break;

                    case "4":
                        newlyAdd = false;
                        UpdateSerie();
                        break;

                    case "5":
                        ShowSerie();
                        break;

                    case "C":
                        Console.Clear();
                        break;

                    case "X":
                        break;

                    default:
                        Console.WriteLine("Comando nao encontrado");
                        Console.WriteLine("Tente novamente");
                        Console.WriteLine();
                        break;
                }
            }
        }

        private static string AskInput() 
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opcao desejada:");
            Console.WriteLine("1- Listar series");
            Console.WriteLine("2- Inserir nova serie");
            Console.WriteLine("3- Remover serie");
            Console.WriteLine("4- Modificar serie");
            Console.WriteLine("5- Visualizar serie");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair");

            string input = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return input;
        }

        //methods of the switch in main
        private static void ListSerie() 
        {
            var lista = repository.ReturnList();

            Console.WriteLine("Lista:");

            if (lista.Count == 0) 
            {
                Console.WriteLine("Nenhuma serie cadastrada.");
                return;
            }

            foreach (var serie in lista) 
            {
                if(!serie.removed)
                    Console.WriteLine("#ID: {0}: - {1}", serie.GetId(), serie.GetTitle());
            }
        }

        private static Serie AddSerie(int old) 
        {
            string newTitle;
            string newDesciption;
            int newYear;
            int newGenre;

            Console.WriteLine("Digite a nova serie:");
            
            Console.Write("Titulo: ");
            newTitle = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Descricao: ");
            newDesciption = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Ano: ");
            newYear = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Selecione um Genero:");
            foreach (int i in Enum.GetValues(typeof(Genre))) 
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genre), i));
            }
            Console.WriteLine();
            Console.Write("Digite o numero do genero de acordo com a tabela acima: ");
            newGenre = int.Parse(Console.ReadLine());

            int id;
            if (newlyAdd)
            {
                id = repository.NextId();
            }
            else 
            {
                id = old;
            }

            Serie newSerie = new Serie(id,
                                        newTitle,
                                        newDesciption,
                                        newYear,
                                        (Genre)newGenre);
            if (newlyAdd) 
            {
                repository.Insert(newSerie);
            }

            return newSerie;
        }

        private static void DeleteSerie() 
        {
            Console.Write("Digite o Id da serie a ser deletada: ");
            int id = int.Parse(Console.ReadLine());

            repository.Delete(id);
        }

        private static void UpdateSerie() 
        {
            int id = ShowSerie();

            Console.WriteLine("Digite as novas informacoes: ");

            Serie nova = AddSerie(id);

            repository.Update(id, nova);

        }

        private static int ShowSerie() 
        {
            var lista = repository.ReturnList();
            Console.Write("Digite a Id para visualizar: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(lista[id].ToString());

            return id;
        }
    }
}
