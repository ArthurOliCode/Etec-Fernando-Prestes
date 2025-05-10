internal class Program
{
    public static void Main(string[] args)
    {
        string nome = "Arthur";
        string nome2 = "";
        int idade = 0;
        var names = new[] {"", "", "", ""};
        Console.WriteLine("Meu nome é " + nome);
        Console.WriteLine("Muito prazer em te conhecer! Qual é o seu nome? ");
        nome2 = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Muito prazer em te conhecer " + nome2 + "!");
        if(nome2.Equals("Arthur")){
            Console.WriteLine();
            Console.WriteLine("Seu nome é igual ao meu!!");
        }else{
            
            Console.WriteLine("Seu nome é legal!!");
        }



        
    }
}