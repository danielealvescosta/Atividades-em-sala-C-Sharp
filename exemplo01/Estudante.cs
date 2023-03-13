using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo01
{
    internal class Estudante
    {
        public string RA;
        public string nome;
        public double notaBim1;
        public double notaBim2;

        public double media()
        {
            double resultado;

            resultado = (notaBim1 + notaBim2) / 2.0;

            return resultado;
        }
        public string relatorio()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Nome: {0}\n", nome);
            sb.AppendFormat("RA: {0}\n", RA);
            sb.AppendFormat("Nota 1° Bimestre: {0}\n", notaBim1);
            sb.AppendFormat("Nota 2° Bimestre: {0}\n", notaBim2);
            sb.AppendFormat("Média: {0}", media());

            return sb.ToString();
        }
    }
}
