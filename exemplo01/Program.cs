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

            aluno1.nome = "João Silva";
            aluno1.RA = "1234X";
            aluno1.notaBim1 = 8.5;
            aluno1.notaBim2 = 9.0;

            Console.WriteLine(aluno1.relatorio());

            Console.WriteLine("Média: {0}", aluno1.media());
        }
    }
}
