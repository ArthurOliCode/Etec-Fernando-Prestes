using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
         string resp;
         string frase; //String para o texto base
        do{
            //comandos
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
}