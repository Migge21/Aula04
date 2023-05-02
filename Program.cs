using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Aula 04. - Data:27/03/23
             Lab.207 Bloco J - Sistema de informação – 3 / 2022
             Aluno(a): Miguel Sanches Braga Inácio
             Profa.Michelle Nery Nascimento*/

            //Exerc 1.Escreva um programa que leia 3 valores inteiros e diferentes e mostre-os em ordem decrescente
            /*
            //variavel
            int num1, num2, num3,salvo;
            //entrada de dados
            Console.WriteLine("Digite 3 números: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            
            if (num1 < num3)
            {
                salvo = num1;
                num1 = num3;
                num3 = salvo;
            }
            if(num2 < num3)
            {
                salvo = num2;
                num2 = num3;
                num3 = salvo;
            }
            //saida
            Console.WriteLine("A ordem decrescente é:"+num1+", "+num2+", "+num3);
            */

            /*Exerc 2.Escreva um programa para calcular a soma de 10 números quaisquer fornecidos pelo
            usuário*/
            //a variavel soma armazena o valor de um inserido e depois soma com o novo valor digitado posteriormente
            //a variavel contador vai adicionando o valor +1 a cada vez que um numero é digitado
            //o while para quando o contador for repetido 10 vezes
            /*
            float num, soma=0,contador=0;
            while (contador < 10)
            {
                Console.WriteLine("Digite um valor:");
                num = float.Parse(Console.ReadLine());
                soma+=num;
                contador++;
            }

            Console.WriteLine("A soma dos valores é:" + soma);
            */
            /*Exerc 3.Escreva um programa para ler a idade de 40 pessoas, exibir a idade da pessoa mais nova,
            calcular a idade média e calcular a porcentagem de pessoas com idade entre 24 e 30 anos.*/
            //variavel
            /*
            int idade, contador = 0,conta_24_30=0,nova=100, porcentagem;
            float media,soma=0;//para usar += a variavel tem que ter um valor predefinido vide soma=0
            //entrada de dados
            while (contador < 40)
            {
                Console.WriteLine("Digite a idade da pessoa:");
                idade = int.Parse(Console.ReadLine());
                soma += idade;
                if(idade < nova)
                {
                    nova = idade;//armazena a idade menor que o valor dado anteriormente
                }
                if(idade >= 24 && idade <= 30)
                {
                    conta_24_30++;
                }

                contador++;
            }
            media = soma / 40;
            porcentagem = (conta_24_30 / 40) * 100;
            //saida
            Console.WriteLine("A idade da mais nova é: "+nova);
            Console.WriteLine("A média das idades é: "+media);
            Console.WriteLine("A porcentagem de idades entre 24 e 30 anos é: "+porcentagem);*/

            /*Exerc 4.Deseja-se fazer uma pesquisa a respeito do consumo mensal de energia elétrica em uma
            determinada cidade. Para isso, são fornecidos os seguintes dados por consumidor:
            • preço do kWh;
            • quantidade de kWh consumidos durante o mês;
            O número de consumidores que participarão da pesquisa é igual a 80.Faça um programa que
            leia os dados descritos acima, calcule e imprima
            (a) para cada consumidor, o total a pagar,
            (b) o maior consumo verificado,
            (c) o menor consumo verificado,
            (d) a média geral de consumo

            //variavel
            int consumidores = 0;
            float preco, quantidade, total=0,todoconsumo=0, media, maior= float.MinValue, menor =float.MaxValue;

            //entrada de dados
            while (consumidores < 80)
            {
                Console.WriteLine("Digite o preco do kWh: ");
                preco = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quantidade de kWh no mes: ");
                quantidade = float.Parse(Console.ReadLine());

                if (quantidade > maior)
                {
                    maior = quantidade;
                }
                if(quantidade < menor )
                {
                    menor = quantidade;
                }
                total = preco * quantidade;
                todoconsumo += quantidade;

                consumidores++;

            }
            media = todoconsumo / 80;

            //saida
            Console.WriteLine("Total a pagar por consumidor: "+total);
            Console.WriteLine("Maior consumo: " + maior);
            Console.WriteLine("Menor consumo: " + menor);
            Console.WriteLine("A média de consumo: " + media);*/

            /*Exerc 5. Desenvolver um programa que efetue a soma de todos os números ímpares que são
              múltiplos de três e que se encontram no conjunto dos números de 500 até 2100*/
            /*
            int soma=0,contador = 501;
            while(contador <=2100) 
            {
                if(contador % 3 == 0)
                {
                    soma += contador;
                }
                contador+=2;
            }
            Console.WriteLine("A soma de todos os números impares: " + soma);*/

            /*Exerc 6.Escrever um programa que leia 60 números e conte quantos deles estão nos seguintes
            intervalos: [0-25], [26-50], [51-75] e [76-100]*/
            //variavel
            /*
            int num, cont_25=0, cont_50=0, cont_75=0, cont_100=0,normal=0;
            
            //entrada de dados
            while (normal<60) 
            {
                Console.WriteLine("Digite um valor: ");
                num = int.Parse(Console.ReadLine());
                if(num>=0 && num <= 25)
                {
                    cont_25 ++;
                }
                else if (num >= 26 && num <= 50)
                {
                    cont_50 ++;
                }
                else if (num >= 51 && num <= 75)
                {
                    cont_75 ++;
                }
                else if (num >= 76 && num <= 100)
                {
                    cont_100 ++;
                }
                else
                {
                    Console.WriteLine("O valor digitado está fora do limite");
                }

                normal++;
            }
            //saida
            Console.WriteLine("Entre 0 e 25 são: " + cont_25 + " números");
            Console.WriteLine("Entre 26 e 50 são: " + cont_50 + " números");
            Console.WriteLine("Entre 51 e 75 são: " + cont_75 + " números");
            Console.WriteLine("Entre 76 e 100 são: " + cont_100 + " números");*/


            /*Exerc 7.Escreva um programa para calcular e escrever o valor final de S:
                S = 1/1 + 2/4 + 3/9 + 4/16 + 5/25 + 6/36 + ... 10/100 */
            /*
            //variavel
            float s = 0;
            float numerador = 1;
            
            //entrada de dados
            do
            {
                
                numerador++;
                s += numerador /(numerador*numerador);
                Console.WriteLine(s);
               
            } while (numerador <= 10);
            
            //saida
            Console.WriteLine("O valor final de S é: " + s);*/

            /*Exerc 8.A secretaria de saúde de uma cidade fez uma pesquisa entre seus habitantes, coletando
                  dados sobre a idade e a quantidade de filhos de cada habitante. A secretaria deseja saber:
                  a) média da idade da população;
                  b) média do número de filhos;
                  c) maior idade;
                  d) percentual de pessoas acima de 60 anos.
                  O final da leitura de dados se dará com a entrada de uma idade negativa
              //variavel
              int idade, filhos,soma_idade=0,soma_filhos=0, maior = 0, contador_60 = 0,contador=0;
              float media_idade, media_filhos,percentual;
              //entrada de dados

                  Console.WriteLine("Digite sua idade:");
                  idade = int.Parse(Console.ReadLine());
                  Console.WriteLine("Digite quantos filhos você tem:");
                  filhos = int.Parse(Console.ReadLine());

              while (idade > 0)
              {
                  Console.WriteLine("Digite sua idade:");
                  idade = int.Parse(Console.ReadLine());
                  Console.WriteLine("Digite quantos filhos você tem:");
                  filhos = int.Parse(Console.ReadLine());

                  soma_idade += idade;
                  soma_filhos += filhos;


                  if (idade > maior)
                  {
                      maior = idade;//armazena a idade maior que o valor dado anteriormente
                  }
                  if (idade > 60)
                  {
                      contador_60++;
                  }
                  if(idade < 0)
                  {
                      contador--;
                  }
                  contador++;
              }
              media_idade = (float)soma_idade / contador;
              media_filhos = (float)soma_filhos / contador;
              percentual = (contador_60 / (float)contador) * 100;
              //saida
              Console.WriteLine("A média de idade da população é: "+media_idade);
              Console.WriteLine("A média do número de filhos da população é: " + media_filhos);
              Console.WriteLine("A maior idade é: " + maior);
              Console.WriteLine("O percentual de pesssoas acima de 60 anos é: " + percentual);*/

            /*Exerc 9. Faça um programa para ler as coordenadas (X, Y) de uma quantidade indeterminada de
             pontos no sistema cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O
             programa será encerrado quando as duas coordenadas digitadas forem 0 (nesta situação, sair
             sem escrever mensagem alguma).
             Para os dados de entrada abaixo Deve ser gerada a seguinte saída
             2 2 primeiro quadrante
             3 -2 quarto quadrante
             4 7 primeiro quadrante
            -8 -1 terceiro quadrante
            -7 1 segundo quadrante*/
            /*
            int x = 1, y = 1;



            while (x != 0 && y != 0)
            {
                Console.WriteLine("Digite o valor de x e y:");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro quadrante " + x + ", " + y + "\n");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo quadrante " + x + ", " + y + "\n");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro quadrante " + x + ", " + y + "\n");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Quarto quadrante " + x + ", " + y + "\n");
                }
            }*/


        }
    }
}