using System;

namespace exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario;
            double aumentoPercentual;
            string aumentoPercentualString;
            double salariofinal;

            
            Console.WriteLine("Digite o seu salário");
            salario = Convert.ToDouble(Console.ReadLine());

           if(salario <= 280)
            {
                aumentoPercentual = 0.2;
                aumentoPercentualString = "20%";
            }else if(salario > 280 && salario <=700)
            {
                aumentoPercentual = 0.15;
                aumentoPercentualString = "15%";
            }
            else if (salario > 700 && salario <= 1500)
            {
                aumentoPercentual = 0.1;
                aumentoPercentualString = "10%";
            }
            else
            {
                aumentoPercentual = 0.05;
                aumentoPercentualString = "5%";
            }

            Console.WriteLine($"O salário orinal é {salario}R$\ne receberá um aumento de {aumentoPercentualString}\nou seja um acréscimo de {salario * aumentoPercentual}\nResultando num salário final de {salario += salario * aumentoPercentual}");



        }
    }
}
