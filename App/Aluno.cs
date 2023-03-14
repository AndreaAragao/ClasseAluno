using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto06.App
{
    internal class Aluno
    {
        public double Nota1 { get; private set; }

        public double Nota2 { get; private set; }

        public double Nota3 { get; private set; }

        public Aluno(double nota1, double nota2, double nota3)
        {
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        public double mediaNotas()
        {
            double mediaNotas = (Nota1 + Nota2 + Nota3) / 3;
            return mediaNotas;
        }

        public string resultado()
        {
            if(mediaNotas() < 4)
            {
                return "Reprovado";
            }
            else if (mediaNotas() >= 4 && mediaNotas() < 6)
            {
                return "Exame Especial";
            }
            else
            {
                return "Aprovado";
            }
        }

    }
}
