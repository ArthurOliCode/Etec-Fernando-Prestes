// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.ComponentModel;

internal class Program{
    private static void Main(string[] args){

        string resp="";

        do
        {
            Console.Clear();
            Console.WriteLine("\n\t\t\t---------------------------");
            Console.WriteLine("\t\t\t\tBem-vindo ao Menu");
            Console.WriteLine("\t\t\t---------------------------");

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("|1° opção - contador vogais e consoantes|");
            Console.WriteLine("|2° opção - criptografia Zenit Polar    |");
            Console.WriteLine("|3° opção - descontinuar                |");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Digite uma das opções acima: ");

            resp = Console.ReadLine();
            resp = resp[0].ToString();
            switch (resp)
            {
                case "1":
                    ContVeC();
                    break;
                case "2":
                    cripto();
                    break;
                default:
                    break;
            }

            //resposta para o loop
            Console.WriteLine("\nDeseja continuar o programa principal?: ");
            resp = Console.ReadLine();
            resp = resp[0].ToString().ToLower();
        }while(resp.Equals("s"));
    }

    public static void cripto(){
        string resp;
        string frase; //String para o texto base
        do{
            //comandos
            Console.Clear();
            Console.WriteLine("\n\t\t--------------------------------");
            Console.WriteLine("\t\tBem vindo ao sistema Zenit Polar");
            Console.WriteLine("\t\t--------------------------------");
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("Digite uma frase por favor: ");
            frase = Console.ReadLine();
            
            Console.WriteLine("A criptografia do seu texto é: " + FormaMSG(frase));

            //resposta para o loop
            Console.WriteLine("\nDeseja continuar?: ");
            resp = Console.ReadLine();
            resp = resp[0].ToString().ToLower();
        }while(resp.Equals("s"));
    }

    public static string Zenit(string letra){ //Método para criptografia ZenitPolar
        letra = letra.ToLower();
        switch(letra){
            case "z":
                return "p";
            case "p":
                 return "z";
            case "e":
                return "o";
            case "o":
                return "e";
            case "n":
                return "l";
            case "l":
                return "n";
            case "i":
                return "a";
            case "a":
                return "i";
            case "t":
                return "r";
            case "r":
                return "t";
            case "Z":
                return "P";
            case "P":
                return "Z";
            case "E":
	    	    return "O";
	        case "O":
	    	    return "E";
	        case "N":
	    	    return "L";
	        case "L":
	    	    return "N";
	        case "I":
	    	    return "A";
	        case "A":
	    	    return "I";
	        case "T":
	    	    return "R";
	        case "R":
	    	    return "T";
            default:
                return letra;
        }
    }

    public static string FormaMSG(string txt){
        string txtCript = ""; //Strinh para o texto criptografado
        for(int i=0; i<txt.Length; i++){
            string l = txt[i].ToString();
            txtCript += Zenit(l);
        }
        return txtCript;
    }

    public static void ContVeC()
    {
        string vFrase, vLetra, resp;
        int contA = 0, contE = 0, contF = 0, contI = 0, contO = 0, contU = 0, consO = 0, contC = 0, contV=0;
        do
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Bem-vindo ao programa!!!");
            Console.Write("Escreva a frase desejada:");
            vFrase = Console.ReadLine();//Ler (vFrase)

            int vTan = vFrase.Length;

            for (int i = 0; i < vTan; i++)
            {
                vLetra = vFrase.Substring(i, 1);
                switch (vLetra.ToLower())
                {
                    case "a":
                        contA++;
                        break;

                    case "e":
                        contE++;
                        break;

                    case "i":
                        contI++;
                        break;

                    case "o":
                        contO++;
                        break;

                    case "u":
                        contU++;
                        break;

                    case " ":
                        contV++;
                        break;
                    default:
                        contC++;
                        break;
                }
            }
            Console.WriteLine("\n\nSua frase foi: " + vFrase);
            Console.WriteLine("Sua frase tem " + vFrase.Length);
            Console.WriteLine("Tem " + contA + " letras A");
            Console.WriteLine("Tem " + contE + " letras E");
            Console.WriteLine("Tem " + contI + " letras I");
            Console.WriteLine("Tem " + contO + " letras O");
            Console.WriteLine("Tem " + contU + " letras U");
            Console.WriteLine("\n\nE possui " + contC + " consoantes!");
            Console.WriteLine("\nDeseja continuar o programa de contagem?: ");
            resp = Console.ReadLine();
            resp = resp[0].ToString().ToLower();
        } while (resp.Equals("s"));
    }
}