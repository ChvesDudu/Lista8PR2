using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista8PR2
{
    internal class Program
    {
        public static void Ex1()
        {
            Console.WriteLine("Ex1");
            {
                int quantidadeTotal = 0;
                decimal valorTotal = 0;

                do
                {
                    Console.Write("Digite a quantidade de itens adquiridos (ou <= 0 para sair): ");
                    int quantidade = int.Parse(Console.ReadLine());

                    if (quantidade <= 0)
                        break;

                    Console.Write("Digite o preço do produto: ");
                    decimal preco = decimal.Parse(Console.ReadLine());

                    quantidadeTotal += quantidade;
                    valorTotal += quantidade * preco;

                } while (true);

                Console.WriteLine("Quantidade total de itens adquiridos: " + quantidadeTotal);
                Console.WriteLine("Valor total da compra: " + valorTotal.ToString("C"));
            }
        }
        public static void Ex2()
        {
            Console.WriteLine("Ex2");
            {
                string produtoMaisCaro = "";
                decimal maiorInvestimento = 0;

                string produtoMaisBarato = "";
                decimal menorInvestimento = decimal.MaxValue;

                string opcao;

                do
                {
                    Console.Write("Digite o nome do produto (ou 'sair' para encerrar): ");
                    string nomeProduto = Console.ReadLine();

                    if (nomeProduto.ToLower() == "sair")
                        break;

                    Console.Write("Digite o número de itens desse produto: ");
                    int quantidade = int.Parse(Console.ReadLine());

                    Console.Write("Digite o preço de compra do produto: ");
                    decimal preco = decimal.Parse(Console.ReadLine());

                    decimal investimentoTotal = quantidade * preco;

                    if (investimentoTotal > maiorInvestimento)
                    {
                        produtoMaisCaro = nomeProduto;
                        maiorInvestimento = investimentoTotal;
                    }

                    if (investimentoTotal < menorInvestimento)
                    {
                        produtoMaisBarato = nomeProduto;
                        menorInvestimento = investimentoTotal;
                    }

                    Console.Write("Deseja cadastrar mais um produto? (s/n): ");
                    opcao = Console.ReadLine();

                } while (opcao.ToLower() == "s");

                Console.WriteLine("Produto com maior investimento: " + produtoMaisCaro);
                Console.WriteLine("Maior investimento: " + maiorInvestimento.ToString("C"));
                Console.WriteLine("Produto com menor investimento: " + produtoMaisBarato);
                Console.WriteLine("Menor investimento: " + menorInvestimento.ToString("C"));
            }
        }
        public static void Ex3()
        {
            Console.WriteLine("Ex3");
            {
                Console.Write("Digite o número de avaliações: ");
                int numeroAvaliacoes = int.Parse(Console.ReadLine());

                decimal somaPesos = 0;

                do
                {
                    Console.Write("Digite o peso da avaliação: ");
                    decimal peso = decimal.Parse(Console.ReadLine());
                    somaPesos += peso;

                    Console.Write("Deseja cadastrar mais um peso? (s/n): ");
                    string opcao = Console.ReadLine();

                    if (opcao.ToLower() == "n")
                        break;

                } while (true);

                if (somaPesos < 100)
                {
                    Console.WriteLine("Soma total dos pesos é insuficiente.");
                }
                else if (somaPesos > 100)
                {
                    Console.WriteLine("Soma total dos pesos é excedente.");
                }
                else
                {
                    Console.WriteLine("Soma total dos pesos é adequada.");
                }
            }
        }
        public static void Ex4()
        {
            Console.WriteLine("Ex4");
            {
                string sigla;
                string nomeEstado = "";

                do
                {
                    Console.Write("Digite a sigla do estado (ou 'sair' para encerrar): ");
                    sigla = Console.ReadLine().ToUpper();

                    switch (sigla)
                    {
                        case "AC":
                            nomeEstado = "Acre";
                            break;
                        case "AL":
                            nomeEstado = "Alagoas";
                            break;
                        case "AP":
                            nomeEstado = "Amapá";
                            break;
                        case "AM":
                            nomeEstado = "Amazonas";
                            break;
                        case "BA":
                            nomeEstado = "Bahia";
                            break;
                        case "CE":
                            nomeEstado = "Ceará";
                            break;
                        case "DF":
                            nomeEstado = "Distrito Federal";
                            break;
                        case "ES":
                            nomeEstado = "Espírito Santo";
                            break;
                        case "GO":
                            nomeEstado = "Goiás";
                            break;
                        case "MA":
                            nomeEstado = "Maranhão";
                            break;
                        case "MT":
                            nomeEstado = "Mato Grosso";
                            break;
                        case "MS":
                            nomeEstado = "Mato Grosso do Sul";
                            break;
                        case "MG":
                            nomeEstado = "Minas Gerais";
                            break;
                        case "PA":
                            nomeEstado = "Pará";
                            break;
                        case "PB":
                            nomeEstado = "Paraíba";
                            break;
                        case "PR":
                            nomeEstado = "Paraná";
                            break;
                        case "PE":
                            nomeEstado = "Pernambuco";
                            break;
                        case "PI":
                            nomeEstado = "Piauí";
                            break;
                        case "RJ":
                            nomeEstado = "Rio de Janeiro";
                            break;
                        case "RN":
                            nomeEstado = "Rio Grande do Norte";
                            break;
                        case "RS":
                            nomeEstado = "Rio Grande do Sul";
                            break;
                        case "RO":
                            nomeEstado = "Rondônia";
                            break;
                        case "RR":
                            nomeEstado = "Roraima";
                            break;
                        case "SC":
                            nomeEstado = "Santa Catarina";
                            break;
                        case "SP":
                            nomeEstado = "São Paulo";
                            break;
                        case "SE":
                            nomeEstado = "Sergipe";
                            break;
                        case "TO":
                            nomeEstado = "Tocantins";
                            break;
                        case "SAIR":
                            break;
                        default:
                            Console.WriteLine("Sigla inválida");
                            break;
                    }

                    if (nomeEstado != "")
                    {
                        Console.WriteLine("Nome do estado correspondente: " + nomeEstado);
                        nomeEstado = "";
                    }

                } while (sigla != "SAIR");
            }
        }
        public static void Ex5()
        {
            Console.WriteLine("Ex5");
            {
                int mes;

                do
                {
                    Console.Write("Digite o número do mês (1 a 12): ");
                    mes = Convert.ToInt32(Console.ReadLine());

                    if (mes >= 1 && mes <= 12)
                    {
                        string estacao;

                        switch (mes)
                        {
                            case 12:
                            case 1:
                            case 2:
                                estacao = "Verão";
                                break;
                            case 3:
                            case 4:
                            case 5:
                                estacao = "Outono";
                                break;
                            case 6:
                            case 7:
                            case 8:
                                estacao = "Inverno";
                                break;
                            case 9:
                            case 10:
                            case 11:
                                estacao = "Primavera";
                                break;
                            default:
                                estacao = "";
                                break;
                        }

                        if (estacao != "")
                        {
                            Console.WriteLine("Estação do ano: " + estacao);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Esse mês pertence a duas estações. Informe qual estação (P, V, O, I):");
                            string escolhaEstacao = Console.ReadLine().ToUpper();

                            switch (escolhaEstacao)
                            {
                                case "P":
                                    estacao = "Primavera";
                                    break;
                                case "V":
                                    estacao = "Verão";
                                    break;
                                case "O":
                                    estacao = "Outono";
                                    break;
                                case "I":
                                    estacao = "Inverno";
                                    break;
                                default:
                                    estacao = "Estação inválida";
                                    break;
                            }

                            Console.WriteLine("Estação do ano: " + estacao);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Mês inválido. Digite um número entre 1 e 12.");
                    }

                } while (true);
            }
        }
        public static void Ex6()
        {
            Console.WriteLine("Ex6");
            {
                double peso, altura;
                string continuar;

                do
                {
                    Console.Write("Digite o seu peso em kg: ");
                    peso = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite a sua altura em metros: ");
                    altura = Convert.ToDouble(Console.ReadLine());

                    double imc = peso / (altura * altura);

                    Console.WriteLine("Seu IMC é: " + imc.ToString("0.00"));

                    string faixaPeso;

                    if (imc < 18.5)
                    {
                        faixaPeso = "Abaixo do peso";
                    }
                    else if (imc >= 18.5 && imc <= 24.9)
                    {
                        faixaPeso = "Peso normal";
                    }
                    else if (imc >= 25.0 && imc <= 29.9)
                    {
                        faixaPeso = "Sobrepeso";
                    }
                    else if (imc >= 30.0 && imc <= 34.9)
                    {
                        faixaPeso = "Obesidade grau 1";
                    }
                    else if (imc >= 35.0 && imc <= 39.9)
                    {
                        faixaPeso = "Obesidade grau 2";
                    }
                    else
                    {
                        faixaPeso = "Obesidade grau 3 (mórbida)";
                    }

                    Console.WriteLine("Faixa de peso: " + faixaPeso);

                    Console.WriteLine("Deseja calcular o IMC novamente? (s/n)");
                    continuar = Console.ReadLine();

                } while (continuar.ToLower() == "s");
            }
        }
        public static void Ex7()
        {
            Console.WriteLine("Ex7");
            {
                int numero;

                do
                {
                    Console.Write("Digite um número inteiro maior que 0: ");
                    numero = Convert.ToInt32(Console.ReadLine());

                    if (numero > 0)
                    {
                        Console.WriteLine("Divisores de " + numero + ":");

                        for (int i = 1; i <= numero; i++)
                        {
                            if (numero % i == 0)
                            {
                                Console.WriteLine(i);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Número inválido. Digite um número maior que 0.");
                    }

                } while (numero <= 0);
            }
        }
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("=============MENU=============");
                Console.WriteLine("Para executar ex 1 - digite 1");
                Console.WriteLine("Para executar ex 2 - digite 2");
                Console.WriteLine("Para executar ex 3 - digite 3");
                Console.WriteLine("Para executar ex 4 - digite 4");
                Console.WriteLine("Para executar ex 5 - digite 5");
                Console.WriteLine("Para executar ex 5 - digite 6");
                Console.WriteLine("Para executar ex 5 - digite 7");
                Console.WriteLine("==============================");

                opcao = int.Parse(Console.ReadLine()); //Lê a opção escolhida
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Thanks for using my system!");
                        break;

                    case 1:
                        Ex1();
                        break;

                    case 2:
                        Ex2();
                        break;

                    case 3:
                        Ex3();
                        break;

                    case 4:
                        Ex4();
                        break;

                    case 5:
                        Ex5();
                        break;

                    case 6:
                        Ex6();
                        break;

                    case 7:
                        Ex7();
                        break;
                }

            } while (opcao != 0);
        }
    }
}
