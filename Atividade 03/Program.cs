using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int Referencia;
            do
            {
                Console.Write("\n\n   Atividade 03 - Programação Orientada a Objetos\n   Aluno: Luís Gustavo C. Lenzi - Ciência da Computação");
                Console.Write("\n\n   > [Selecione uma das opções abaixo] <\n\n");
                Console.WriteLine("   [1] - Carimbar [Carimbo]");
                Console.WriteLine("   [2] - Escrever [Caneta]");
                Console.WriteLine("   [3] - Sair");
                Console.Write("\n   Digite aqui qual será a referência desejada >: ");
                Referencia = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (Referencia)
                {
                    case 1:
                        Console.Write("\n\n   Atividade 03 - Programação Orientada a Objetos\n   Aluno: Luís Gustavo C. Lenzi - Ciência da Computação");
                        Console.Write("\n\n   > [Carimbo Selecionado] <");
                        Console.Write("\n\n   Digite qual será a cor >: ");
                        string CCor = System.Console.ReadLine();
                        Console.Write("   Digite qual será a quantidade de carga >: ");
                        int CCarga = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.Write("\n\n   Atividade 03 - Programação Orientada a Objetos\n   Aluno: Luís Gustavo C. Lenzi - Ciência da Computação");
                        Console.Write("\n\n   Digite qual será o texto a ser carimbado >: ");
                        string TTexto = System.Console.ReadLine();
                        Carimbo X = new Carimbo(CCor, CCarga, TTexto);
                        Console.Write("\n   Deseja carimbar? [S/N] >: ");
                        string Carimbar1 = System.Console.ReadLine();
                        if (Carimbar1 == "s" || Carimbar1 == "S")
                        {
                            CCarga = CCarga - 1;
                            X.Usar();
                            Console.ReadKey();
                            Console.Clear();
                            Console.Write("\n\n   Atividade 03 - Programação Orientada a Objetos\n   Aluno: Luís Gustavo C. Lenzi - Ciência da Computação");
                            Console.Write("\n\n   Você ainda possuí [" + CCarga + " Cargas]");
                            Console.Write("\n   Deseja carimbar o > [Restante] < de cargas? [S/N] >: ");
                            string Carimbar = System.Console.ReadLine();
                            if (Carimbar == "s" || Carimbar == "S")
                            {
                                for (int i = 0; i <= CCarga; i++)
                                {
                                    X.Usar();
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            else if (Carimbar == "n" || Carimbar == "N")
                            {
                                Console.Write("\n   Deseja trocar o texto? [S/N] >: ");
                                string TrocarTexto = System.Console.ReadLine();
                                if (TrocarTexto == "s" || TrocarTexto == "S")
                                {
                                    Console.Clear();
                                    Console.Write("\n\n   Atividade 03 - Programação Orientada a Objetos\n   Aluno: Luís Gustavo C. Lenzi - Ciência da Computação");
                                    Console.Write("\n\n   Digite qual será o novo texto >: ");
                                    TTexto = System.Console.ReadLine();
                                    X.TrocarTexto(TTexto);
                                    Console.Write("\n   Deseja carimbar? [S/N] >: ");
                                    string Carimbar3 = System.Console.ReadLine();
                                    if (Carimbar3 == "s" || Carimbar3 == "S")
                                    {
                                        CCarga = CCarga - 1;
                                        X.Usar();
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.Write("\n\n   Atividade 03 - Programação Orientada a Objetos\n   Aluno: Luís Gustavo C. Lenzi - Ciência da Computação");
                                        Console.Write("\n\n   Você ainda possuí [" + CCarga + " Cargas]");
                                        Console.Write("\n   Deseja carimbar o > [Restante] < de cargas? [S/N] >: ");
                                        string Carimbar4 = System.Console.ReadLine();
                                        if (Carimbar4 == "s" || Carimbar4 == "S")
                                        {
                                            for (int i = 0; i <= CCarga; i++)
                                            {
                                                X.Usar();
                                                Console.ReadKey();
                                                Console.Clear();
                                            }
                                        }
                                        else if (Carimbar4 == "n" || Carimbar4 == "N")
                                        {
                                            Console.Write("\n   Como você não deseja carimbar o restante de cargas o valor será resetado.");
                                            Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Write("\n   [Opção Inválida].");
                                            Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                    }
                                    else if (Carimbar3 == "n" || Carimbar3 == "N")
                                    {
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.Write("\n   [Opção Inválida].");
                                        Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                else if (TrocarTexto == "n" || TrocarTexto == "N")
                                {
                                    Console.Write("\n   Deseja trocar a cor? [S/N] >: ");
                                    string TrocarCor = System.Console.ReadLine();
                                    if (TrocarCor == "s" || TrocarCor == "S")
                                    {
                                        Console.Write("\n\n   Digite qual será a nova cor >: ");
                                        CCor = System.Console.ReadLine();
                                        X.TrocarCor(CCor);
                                        Console.Write("\n   Deseja carimbar? [S/N] >: ");
                                        string Carimbar6 = System.Console.ReadLine();
                                        if (Carimbar6 == "s" || Carimbar6 == "S")
                                        {
                                            X.Usar();
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.Write("\n\n   Atividade 03 - Programação Orientada a Objetos\n   Aluno: Luís Gustavo C. Lenzi - Ciência da Computação");
                                            Console.Write("\n\n   Você ainda possuí [" + CCarga + " Cargas]");
                                            Console.Write("\n   Deseja carimbar o > [Restante] < de cargas? [S/N] >: ");
                                            string Carimbar7 = System.Console.ReadLine();
                                            if (Carimbar7 == "s" || Carimbar7 == "S")
                                            {
                                                for (int i = 0; i <= CCarga; i++)
                                                {
                                                    X.Usar();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            }
                                            else if (Carimbar7 == "n" || Carimbar7 == "N")
                                            {
                                                Console.Write("\n   Como você não deseja carimbar o restante de cargas o valor será resetado.");
                                                Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                                                Console.ReadKey();
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                Console.Write("\n   [Opção Inválida].");
                                                Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                                                Console.ReadKey();
                                                Console.Clear();
                                            }
                                        }
                                        else if (Carimbar6 == "n" || Carimbar6 == "N")
                                        {
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Write("\n   [Opção Inválida].");
                                            Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                    }
                                    else if (TrocarCor == "n" || TrocarCor == "N")
                                    {
                                        Console.Write("\n   Deseja recarregar? [S/N] >: ");
                                        string Recarregar = System.Console.ReadLine();
                                        if (Recarregar == "s" || Recarregar == "S")
                                        {
                                            Console.Clear();
                                            Console.Write("\n\n   Atividade 03 - Programação Orientada a Objetos\n   Aluno: Luís Gustavo C. Lenzi - Ciência da Computação");
                                            Console.Write("\n \n  Digite qual será a cor que deseja recarregar >: ");
                                            CCor = Console.ReadLine();
                                            Console.Write("\n   Digite qual será a nova carga >: ");
                                            CCarga = Convert.ToInt32(Console.ReadLine());
                                            X.Carregar(CCor, CCarga);
                                            Console.Write("\n   Agora você possuí [" + CCarga + " Cargas]");
                                            Console.Write("\n   Deseja carimbar o > [Restante] < de cargas? [S/N] >: ");
                                            string Carimbar5 = System.Console.ReadLine();
                                            if (Carimbar5 == "s" || Carimbar5 == "S")
                                            {
                                                for (int i = 0; i <= CCarga; i++)
                                                {
                                                    X.Usar();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            }
                                            else if (Carimbar5 == "n" || Carimbar5 == "N")
                                            {
                                                Console.Write("\n   Como você não deseja carimbar o restante de cargas o valor será resetado.");
                                                Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                                                Console.ReadKey();
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                Console.Write("\n   [Opção Inválida].");
                                                Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                                                Console.ReadKey();
                                                Console.Clear();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.Write("\n   [Opção Inválida].");
                                        Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                else
                                {
                                    Console.Write("\n   [Opção Inválida].");
                                    Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            else
                            {
                                Console.Write("\n   [Opção Inválida].");
                                Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        else if (Carimbar1 == "n" || Carimbar1 == "N")
                        {
                            Console.Write("\n   Como você não deseja carimbar o restante de cargas o valor será resetado.");
                            Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.Write("\n   [Opção Inválida].");
                            Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 2:
                        Console.Write("\n\n   Atividade 03 - Programação Orientada a Objetos\n   Aluno: Luís Gustavo C. Lenzi - Ciência da Computação");
                        Console.Write("\n\n   > [Caneta Selecionada] <");
                        Console.Write("\n\n   Digite qual será a cor >: ");
                        string CCor2 = System.Console.ReadLine();
                        Console.Write("   Digite qual será a quantidade de carga >: ");
                        int CCarga2 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.Write("\n\n   Atividade 03 - Programação Orientada a Objetos\n   Aluno: Luís Gustavo C. Lenzi - Ciência da Computação");
                        Console.Write("\n\n   Digite qual será o texto a ser escrito >: ");
                        string TTexto2 = System.Console.ReadLine();
                        Caneta Y = new Caneta(CCor2, CCarga2, TTexto2);
                        Console.Write("\n   Deseja escrever? [S/N] >: ");

                        //Fiquei com preguiça de trocar o nome das variáveis para [Escrever]
                        //O "carimbar" é só o nome da variável então não influência :)

                        string Carimbar2 = System.Console.ReadLine();
                        if (Carimbar2 == "s" || Carimbar2 == "S")
                        {
                            CCarga2 = CCarga2 - 1;
                            Y.Usar();
                            Console.ReadKey();
                            Console.Clear();
                            Console.Write("\n\n   Atividade 03 - Programação Orientada a Objetos\n   Aluno: Luís Gustavo C. Lenzi - Ciência da Computação");
                            Console.Write("\n\n   Você ainda possuí [" + CCarga2 + " Cargas]");
                            Console.Write("\n   Deseja escrever o > [Restante] < de cargas? [S/N] >: ");
                            string Carimbar3 = System.Console.ReadLine();
                            if (Carimbar3 == "s" || Carimbar3 == "S")
                            {
                                for (int i = 0; i <= CCarga2; i++)
                                {
                                    Y.Usar();
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            else if (Carimbar3 == "n" || Carimbar3 == "N")
                            {
                                Console.Write("\n   Deseja trocar o texto? [S/N] >: ");
                                string TrocarTexto = System.Console.ReadLine();
                                if (TrocarTexto == "s" || TrocarTexto == "S")
                                {
                                    Console.Clear();
                                    Console.Write("\n\n   Atividade 03 - Programação Orientada a Objetos\n   Aluno: Luís Gustavo C. Lenzi - Ciência da Computação");
                                    Console.Write("\n\n   Digite qual será o novo texto >: ");
                                    TTexto = System.Console.ReadLine();
                                    Y.TrocarTexto(TTexto);
                                    Console.Write("\n   Deseja escrever? [S/N] >: ");
                                    string Carimbar4 = System.Console.ReadLine();
                                    if (Carimbar4 == "s" || Carimbar4 == "S")
                                    {
                                        CCarga2 = CCarga2 - 1;
                                        Y.Usar();
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.Write("\n\n   Atividade 03 - Programação Orientada a Objetos\n   Aluno: Luís Gustavo C. Lenzi - Ciência da Computação");
                                        Console.Write("\n\n   Você ainda possuí [" + CCarga2 + " Cargas]");
                                        Console.Write("\n   Deseja escrever o > [Restante] < de cargas? [S/N] >: ");
                                        string Carimbar5 = System.Console.ReadLine();
                                        if (Carimbar5 == "s" || Carimbar4 == "S")
                                        {
                                            for (int i = 0; i <= CCarga2; i++)
                                            {
                                                Y.Usar();
                                                Console.ReadKey();
                                                Console.Clear();
                                            }
                                        }
                                        else if (Carimbar5 == "n" || Carimbar5 == "N")
                                        {
                                            Console.Write("\n   Como você não deseja escrever o restante de cargas o valor será resetado.");
                                            Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Write("\n   [Opção Inválida].");
                                            Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                    }
                                    else if (Carimbar4 == "n" || Carimbar4 == "N")
                                    {
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.Write("\n   [Opção Inválida].");
                                        Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                else if (TrocarTexto == "n" || TrocarTexto == "N")
                                {
                                    Console.Write("\n   Deseja trocar a cor? [S/N] >: ");
                                    string TrocarCor = System.Console.ReadLine();
                                    if (TrocarCor == "s" || TrocarCor == "S")
                                    {
                                        Console.Write("\n\n   Digite qual será a nova cor >: ");
                                        CCor = System.Console.ReadLine();
                                        Y.TrocarCor(CCor);
                                        Console.Write("\n   Deseja escrever? [S/N] >: ");
                                        string Carimbar6 = System.Console.ReadLine();
                                        if (Carimbar6 == "s" || Carimbar6 == "S")
                                        {
                                            Y.Usar();
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.Write("\n\n   Atividade 03 - Programação Orientada a Objetos\n   Aluno: Luís Gustavo C. Lenzi - Ciência da Computação");
                                            Console.Write("\n\n   Você ainda possuí [" + CCarga2 + " Cargas]");
                                            Console.Write("\n   Deseja escrever o > [Restante] < de cargas? [S/N] >: ");
                                            string Carimbar7 = System.Console.ReadLine();
                                            if (Carimbar7 == "s" || Carimbar7 == "S")
                                            {
                                                for (int i = 0; i <= CCarga2; i++)
                                                {
                                                    Y.Usar();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            }
                                            else if (Carimbar7 == "n" || Carimbar7 == "N")
                                            {
                                                Console.Write("\n   Como você não deseja escrever o restante de cargas o valor será resetado.");
                                                Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                                                Console.ReadKey();
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                Console.Write("\n   [Opção Inválida].");
                                                Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                                                Console.ReadKey();
                                                Console.Clear();
                                            }
                                        }
                                        else if (Carimbar6 == "n" || Carimbar6 == "N")
                                        {
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Write("\n   [Opção Inválida].");
                                            Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                    }
                                    else if (TrocarCor == "n" || TrocarCor == "N")
                                    {
                                        Console.Write("\n   Deseja recarregar? [S/N] >: ");
                                        string Recarregar = System.Console.ReadLine();
                                        if (Recarregar == "s" || Recarregar == "S")
                                        {
                                            Console.Clear();
                                            Console.Write("\n\n   Atividade 03 - Programação Orientada a Objetos\n   Aluno: Luís Gustavo C. Lenzi - Ciência da Computação");
                                            Console.Write("\n \n  Digite qual será a cor que deseja recarregar >: ");
                                            CCor2 = Console.ReadLine();
                                            Console.Write("\n   Digite qual será a nova carga >: ");
                                            CCarga2 = Convert.ToInt32(Console.ReadLine());
                                            Y.Carregar(CCor2, CCarga2);
                                            Console.Write("\n   Agora você possuí [" + CCarga2 + " Cargas]");
                                            Console.Write("\n   Deseja escrever o > [Restante] < de cargas? [S/N] >: ");
                                            string Carimbar5 = System.Console.ReadLine();
                                            if (Carimbar5 == "s" || Carimbar5 == "S")
                                            {
                                                for (int i = 0; i <= CCarga2; i++)
                                                {
                                                    Y.Usar();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            }
                                            else if (Carimbar5 == "n" || Carimbar5 == "N")
                                            {
                                                Console.Write("\n   Como você não deseja escrever o restante de cargas o valor será resetado.");
                                                Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                                                Console.ReadKey();
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                Console.Write("\n   [Opção Inválida].");
                                                Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                                                Console.ReadKey();
                                                Console.Clear();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.Write("\n   [Opção Inválida].");
                                        Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                else
                                {
                                    Console.Write("\n   [Opção Inválida].");
                                    Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            else
                            {
                                Console.Write("\n   [Opção Inválida].");
                                Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        else if (Carimbar2 == "n" || Carimbar2 == "N")
                        {
                            Console.Write("\n   Como você não deseja escrever o restante de cargas o valor será resetado.");
                            Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.Write("\n   [Opção Inválida].");
                            Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                }
            } while (Referencia != 3);
        }
    }
}
