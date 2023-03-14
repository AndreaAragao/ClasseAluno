using System;

namespace Projeto06.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno(7, 8, 10);


            Console.WriteLine("Douglas, está com: " + aluno.mediaNotas() + " e está " + aluno.resultado());
        }
    }
}
