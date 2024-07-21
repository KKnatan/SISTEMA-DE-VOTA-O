using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


namespace Sistema_de_votos_meior
{
    internal class Program
    {

        static List<Candidatos> Pessoas = new List<Candidatos>();

        const ConsoleColor DefaultColor = ConsoleColor.White;
        const ConsoleColor ErrorColor = ConsoleColor.Red;
        static void Main()
        {
            Menu();
        }
        static void Menu()
        {


        volta:
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(">>>>>>>>Sistema de votação<<<<<<<<");
            Console.WriteLine(" ________________________________");
            Console.WriteLine("|                                |");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("| 1  -  **Eleições**             |");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("| 2  -  Adicionar Candidato      |");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("| 3  -  Atualizar Candidato      |");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("| 4  -  Remover Candidato        |");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("| 5  -  Visualizar Candidatos    |");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("| 6  -  Sair                     |");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|________________________________|");


            int opção;
            Console.Write("Escolha uma opção:");
            opção = int.Parse(Console.ReadLine().Trim());

            switch (opção)
            {
                case 1: Eleições(); break;
                case 2: Adicionar_Candidato(); break;
                case 3: Atualizar_Candidato(); break;
                case 4: Remover_Candidato(); break;
                case 5: Visualizar_Candidatos(); break;
                case 6:

                    Console.WriteLine("Obrigador por usar o programa....");
                    Thread.Sleep(1000);
                    break;
                default:
                    Console.WriteLine("Essa opção não existe.....voltando");
                    Thread.Sleep(2000);
                    goto volta;

            }


        }
        static void Eleições()
        {
            if (Pessoas.Count < 2)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---------ELEIÇÕES---------");
                Console.ForegroundColor = ErrorColor;
                Console.WriteLine("ERROR:Não é possível fazer uma eleição...Candidatos insuficientes");
                Console.ForegroundColor = ConsoleColor.Yellow;



                Console.ReadKey();
                Menu();
            }
            else
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---------CANDIDATOS---------");

                int voto;
                int total = 0;

                for (int i = 0; i < Pessoas.Count; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"{i + 1} - {Pessoas[i].nome_candidato} ");

                }
                while (true)
                {

                    Console.Write("Digite o número do candidato para votar (0 para encerrar):");

                    if (int.TryParse(Console.ReadLine(), out voto))
                    {


                        if (voto == 0)
                        {
                            break;
                        }
                        else if (voto >= 1 && voto <= Pessoas.Count)
                        {
                            Pessoas[voto - 1].votos_candidatos++;
                            total++;
                        }

                    }
                    else
                    {
                        Console.ForegroundColor = ErrorColor;
                        Console.WriteLine("ERROR: Entrada Inválida");
                        Console.ForegroundColor = ConsoleColor.Yellow;


                    }

                }
                
                Resultados(total,voto);


                Pessoas.Clear()
                Console.ReadKey();
                Menu();

            }


        }
        static void Resultados(int total,int voto)
        {
            var  ordem = Pessoas.OrderByDescending(c => c.votos_candidatos).ToList();
            Console.Clear();
            Console.WriteLine("--------QUANTITATIVO DE VOTOS--------");
            for (int i = 0; i < Pessoas.Count; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"{Pessoas[i].nome_candidato} - {Pessoas[i].votos_candidatos} votos ");

            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Total de votos {total}");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("---------RESULTADOS---------");

            Thread.Sleep(1000);
            
            for(int i = 0;i<ordem.Count;i++)
            Console.WriteLine($"{i+1}º - {ordem[i].nome_candidato} com {ordem[i].votos_candidatos} votos");

        }
        static void Adicionar_Candidato()
        {
            const ConsoleColor DefaultColor = ConsoleColor.White;
            const ConsoleColor ErrorColor = ConsoleColor.Red;
            const ConsoleColor SuccessColor = ConsoleColor.Blue;

            const int IdadeMinima = 35;
            while (true)
            {

                string nome;
                int idade;
                char resp;
                Console.Clear();
                Console.ForegroundColor = SuccessColor;
                Console.WriteLine("|--------ADICIONAR--------|");

                Console.Write("Nome do candidato:");
                nome = Console.ReadLine().Trim();

                

                
                while (true)
                {
                    Console.Write("Idade:");
                   
                    if(int.TryParse(Console.ReadLine().Trim(), out idade))
                    {
                        if (idade >= IdadeMinima)
                        {
                            int voto = 0;
                            Console.WriteLine("Candidato Registrado......");
                            Candidatos pessoas = new Candidatos(nome, idade,voto);
                            Pessoas.Add(pessoas);
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ErrorColor;
                            Console.WriteLine("ERRO:Idade minima não alcançada, o participante deverá ter no minimo 35 anos.");
                            Console.ForegroundColor = SuccessColor;

                            
                        }
                    }
                    else
                    {   
                        Console.ForegroundColor = ErrorColor;
                        Console.WriteLine("ERROR: Insira uma entrada válida");
                        Console.ForegroundColor = SuccessColor;
                    }
                      
                    
                }
                    while (true) 
                {

                     Console.Write("Deseja adicionar mais algum candidato? [S/N]:");

                       
                    if (char.TryParse(Console.ReadLine().Trim().ToUpper(), out resp))
                    {
                        

                        if (resp == 'N')
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("OK......Volte para o menu");
                            Console.ReadKey();
                            Menu();

                        }
                       
                        if (resp == 'S')
                        {
                            break;
                        }
                        else if (resp != 'S' || resp != 'N')
                        {
                            Console.ForegroundColor = ErrorColor;
                            Console.WriteLine("Digite apenas S ou N!!!");
                            Console.ForegroundColor = DefaultColor;

                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ErrorColor;
                        Console.WriteLine("ERRO: insira uma entrada válida");
                        Console.ForegroundColor = DefaultColor;
                    }

                  }


            }

        }
        static void Atualizar_Candidato()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------ATUALIZAR----------");

            string Novonome;
            int Novaidade;
            string nome;

            foreach (Candidatos mostrar in Pessoas)
            {
                Console.WriteLine($"Nome: {mostrar.nome_candidato}|");
                Console.WriteLine($"Idade: {mostrar.idade_candidato}|");
                Console.WriteLine("--------");
            }

            Console.Write("Digite o nome do candidato que queira atualizar:");
            nome = Console.ReadLine();

            Candidatos atualizar = Pessoas.Find(c => c.nome_candidato == nome);
            if (atualizar != null)
            {
                Console.Clear();
                Console.WriteLine("----------ATUALIZAR----------");
                Console.WriteLine($"Nome: {atualizar.nome_candidato}|");
                Console.WriteLine($"Idade: {atualizar.idade_candidato}|");
                Console.WriteLine("--------");

                Console.Write("Digite o novo nome do candidato:");
                Novonome = Console.ReadLine().Trim();

                Console.Write("Digite a nova idade do candidato:");
                bool letras = int.TryParse(Console.ReadLine().Trim(), out Novaidade);
                if (letras == false)
                {
                    Console.WriteLine("Idade apenas contém números!!!");
                }
                
                atualizar.nome_candidato = Novonome;
                atualizar.idade_candidato = Novaidade;

                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Informações atualizadas....");
            }

            else
            {
                Console.ForegroundColor = ErrorColor;
                Console.WriteLine("ERRO:Não há usuarios com esse nome!");
            }
            Console.ReadKey();
            Menu();

        }



        static void Remover_Candidato()
        {
            Console.Clear();
            string nome;
            Console.WriteLine("----------DELETAR----------");
            foreach (Candidatos mostrar in Pessoas)
            {
                Console.WriteLine($"Nome: {mostrar.nome_candidato}|");
                Console.WriteLine($"Idade: {mostrar.idade_candidato}|");
                Console.WriteLine("--------");



            }
            Console.Write("Digite o nome do candidato que queira deletar:");
           
            nome = Console.ReadLine().Trim();

            Candidatos deletar = Pessoas.Find(c => c.nome_candidato == nome);

            if (deletar != null)
            {

                Pessoas.Remove(deletar);
                Console.ForegroundColor= ConsoleColor.Blue;
                Console.WriteLine($"O candidato {deletar.nome_candidato} foi deletado!");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Candidato *{nome}* não foi encontrado");
            }

            Console.ReadKey();
            Menu();
        }





        static void Visualizar_Candidatos()
        {
           

            Console.Clear();

            Console.WriteLine("|---------VISUALIZAR--------|");
            foreach(Candidatos mostrar in Pessoas)
            {
                Console.WriteLine($"Nome: {mostrar.nome_candidato}|");
                Console.WriteLine($"Idade: {mostrar.idade_candidato}|");
                Console.WriteLine("--------");


                
            }
            Console.ReadKey();
            Menu();



        }

        class Candidatos
        {
            public string nome_candidato { get; set; }
            public int idade_candidato { get; set; }

            public int votos_candidatos {  get; set; }

            public Candidatos(string Nome, int Idade,int voto)
            {
                nome_candidato = Nome;
                idade_candidato= Idade;
                votos_candidatos = voto;
            }

        }
    }
}
