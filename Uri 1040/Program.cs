using System;
using System.Globalization;
namespace Uri_1040
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, m,ne,nf;
            int p1 = 2, p2 = 3, p3 = 4, p4 = 1;

            string[] vetor = Console.ReadLine().Split(' ');
            n1 = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(vetor[2], CultureInfo.InvariantCulture);
            n4 = double.Parse(vetor[3], CultureInfo.InvariantCulture);

            m = (double)(n1 * p1 + n2 * p2 + n3 * p3 + n4 * p4) / (p1 + p2 + p3 + p4);

            if(m >= 5.0 && m <= 6.9)
            {
                Console.WriteLine("Aluno em exame");
                Console.WriteLine();
                Console.Write("Nota do exame : ");
                ne = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                nf = (m + ne)/2;
                if(nf >= 5.0)
                {
                    Console.WriteLine("Aluno Aprovado");
                    Console.WriteLine("Média final : "+nf);
                }
                else if(nf<=4.9)
                {
                    Console.WriteLine("Aluno Reprovado");
                    Console.WriteLine("Média final : " + nf);
                }
            }
            else if(m<=4.9)
            {
                Console.WriteLine();
                Console.WriteLine("Média : " + m.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno Reprovado");
            }
            else if(m>=7.0)
            {

                Console.WriteLine();
                Console.WriteLine("Média : " + m.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno Aprovado");

            }


            
        }
    }
}
