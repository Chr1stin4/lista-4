using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercício 1

            //essa afirmativa é falsa pois não tem como atribuir o float por int,mas int para float é possível
            //exemplos:
            //int a = 5;
            //float b = a;
            //Console.WriteLine(b); // resultado: 5.0

            //float c = 7.5f;
            //int d = (int)c;
            //Console.WriteLine(d); // resultado: 7
            //

            //exercício 2
            //Console.read() le apenas um caracter
            //Console.readline() le mais de um caracter 

            //exercício 3
            // o valor tem que ser valido para o tipo de variavel que está sendo aplicado

            //exercício 4           
            //o objetivo do programa é verificar se o valor é par e maioe que 10
            //se voce entrar com 8 sera "mensagem 2"
            //se voce entrar com 27 sera "mensagem 2"
            //se voce entrar com 28 sera "mensagem 1"

            //exercício 5
            //Console.Write("Digite a posição inicial do objeto (em metros): ");
            //double d0 = double.Parse(Console.ReadLine());

            //Console.Write("Digite a velocidade do objeto (em metros por segundo): ");
            //double v = double.Parse(Console.ReadLine());

            //Console.Write("Digite o tempo de movimento do objeto (em segundos): ");
            //double t = double.Parse(Console.ReadLine());

            // Cálculo da posição final
            //double d = d0 + v * t;

            //// Saída de dados
            //Console.WriteLine("A posição final do objeto é: {0} metros", d);

            //exercicio 6
            //Random random = new Random();
            //int num = random.Next(1, 101);

            //// Verifica se o número é divisível por 3, 5 e 10
            //if (num % 3 == 0 && num % 5 == 0 && num % 10 == 0)
            //{
            //    Console.WriteLine("{0} é divisível por 3, 5 e 10", num);
            //}

            // Verifica se o número é divisível por 3 e 5
            //if (num % 3 == 0 && num % 5 == 0)
            //{
            //    Console.WriteLine("{0} é divisível por 3 e 5", num);
            //}

            // Verifica se o número é divisível somente por 3
            //if (num % 3 == 0 && num % 5 != 0)
            //{
            //    Console.WriteLine("{0} é divisível somente por 3", num);
            //}

            // Verifica se o número é divisível somente por 5
            //if (num % 5 == 0 && num % 3 != 0)
            //{
            //    Console.WriteLine("{0} é divisível somente por 5", num);

            //exercicio 7

            //Console.WriteLine("Informe o km onde sua casa está localizada: ");
            //int kmCasa = int.Parse(Console.ReadLine());
            //Calcula a distância percorrida pelo aluno
            //int distancia = int.Parse(kmCasa - 100);
            //Calcula o tempo médio gasto por km
            //double tempoMedioPorKm = 0.5;
            //Calcula o tempo gasto pelo aluno
            //double tempoGasto = distancia * tempoMedioPorKm;

            //Console.WriteLine("O tempo gasto para chegar à escola é de: " + tempoGasto + " horas.");

            //exercício 8

            //Console.WriteLine("Informe a quantidade de unidades vendidas: ");
            //int quantidade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Informe a marca do produto: ");
            //string marca = Console.ReadLine();

            //double precoUnitario = 0;
            //double custo = 0;
            //double imposto = 0;

            //switch (marca.ToUpper())
            //{
            //    case "ROYAL":
            //        precoUnitario = 129.50;
            //        custo = 77.5;
            //        imposto = 3;
            //        break;
            //    case "WISKAS":
            //        precoUnitario = 182.78;
            //        custo = 89.7;
            //        imposto = 7.5;
            //        break;
            //    case "GOLDEN":
            //        precoUnitario = 159.46;
            //        custo = 71.7;
            //        imposto = 22.5;
            //        break;
            //    case "NUTRIEN":
            //        precoUnitario = 144.80;
            //        custo = 88.9;
            //        imposto = 25;
            //        break;                                                                                                                     
            //    case "SPECIALCAT":
            //        precoUnitario = 205.40;
            //        custo = 83.2;
            //        imposto = 22;
            //        break;
            //    case "MARBA":
            //        precoUnitario = 125.10;
            //        custo = 90.4;
            //        imposto = 17.9;
            //        break;
            //    case "GATUS":
            //        precoUnitario = 133.99;
            //        custo = 94.6;
            //        imposto = 20;
            //        break;
            //    default:
            //        Console.WriteLine("Marca inválida.");
            //        return;
            //}

            //double valorTotal = quantidade * precoUnitario;
            //double lucroLiquido = (precoUnitario - (custo / 100 * precoUnitario)) - (imposto / 100 * precoUnitario);

            //Console.WriteLine("Valor total da compra: R$" + valorTotal);
            //Console.WriteLine("Lucro líquido: R$" + lucroLiquido);





        }
    }
     
}

   


