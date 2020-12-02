using System;
using POO_Celular.Classes;

namespace POO_Celular
{
    class Program
    {
        static void Main(string[] args)
        { // Instanciando

            Aluno aluno1 = new Aluno();
            Console.ForegroundColor = ConsoleColor.Red;
            
            Console.Write("Digite o nome do aluno: ");
            aluno1.nome = Console.ReadLine();

            Console.Write("Insira o nome do curso: ");
            aluno1.curso = Console.ReadLine();

            Console.Write("Insira a idade do aluno: ");
            aluno1.idade = int.Parse (Console.ReadLine()); // conversão de um numero pra leitura no terminal

            Console.Write("Insira o RG do aluno: ");
            aluno1.rg = (Console.ReadLine());

            Console.Write("O aluno é bolsista? (S/N) ");
            string resposta = Console.ReadLine();

            if(resposta == "S"){
                aluno1.bolsista = true;
            }else if(resposta == "N"){
                aluno1.bolsista = false;
            }

            Console.Write("Insira a média do aluno: ");
            aluno1.mediaFinal = float.Parse(Console.ReadLine());

            Console.Write("Insira o valor da mensalidade: ");
            aluno1.valorDaMensalidade = double.Parse(Console.ReadLine());

            Console.ResetColor();

            Console.WriteLine("---------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            

            // Declarar métodos

            Console.WriteLine(aluno1.nome);
            Console.WriteLine(aluno1.curso);
            Console.WriteLine(aluno1.idade);
            Console.WriteLine(aluno1.rg);
            // Console.WriteLine(aluno1.bolsista);
            Console.WriteLine(aluno1.mediaFinal);
            Console.WriteLine(aluno1.valorDaMensalidade);
                // funcões/metódos definidos
            aluno1.VerMediaFinal(aluno1.mediaFinal);
            aluno1.VerMensalidade(aluno1.bolsista, aluno1.valorDaMensalidade);

            Console.ResetColor();


        }
    }
}
