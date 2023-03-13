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
        private double notaBim1;
        private double notaBim2;

        public Estudante ()
        {
            nome = "Desconhecido";
            RA = "000X";
            notaBim1 = 0.0;
            notaBim2 = 0.0;
        }

        public void setNotaBim1(double nota)
        {
            if(nota>=0 && nota<=10)
            {
                notaBim1 = nota;
            }
        }

        public void setNotaBim2(double nota)
        {
            if (nota >= 0 && nota <= 10)
            {
                notaBim2 = nota;
            }
        }

        public double getNotaBim1()
        {
            return notaBim1;
        }

        public double getNotaBim2()
        {
            return notaBim2;
        }

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
