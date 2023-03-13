using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudante aluno1;
            aluno1 = new Estudante();

            /*double nota;

            Console.Write("Digite uma nota 1: ");
            nota = double.Parse(Console.ReadLine());
            aluno1.setNotaBim1(nota);

            Console.Write("Digite uma nota 2: ");
            nota = double.Parse(Console.ReadLine());
            aluno1.setNotaBim2(nota);*/

            Console.WriteLine(aluno1.relatorio());

        }
    }
}
