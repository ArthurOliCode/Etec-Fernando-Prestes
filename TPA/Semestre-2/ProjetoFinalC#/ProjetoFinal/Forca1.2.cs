using System;
using System.Threading;

namespace MenuPrincipal
{
    internal class Forca1_2
    {
        public static void Jogo_Forca()
        {

            int escolha_Menu = escolha_Forca();
            if(escolha_Menu == 1){
                jogo1();
            }else{
                jogo2();
            }
            
                
        }



        // Função que desenha a forca
        static void DesenhaForca(int erros)
        {
        
            int ScreenSizeW = Console.WindowWidth / 5;
            int ScreenSizeH = Console.WindowHeight / 5;



            string topo_desenho = @"





                                    █████╗█████╗█████╗█████╗█████╗
                                    ╚════╝╚════╝╚════╝╚════╝╚════╝
                                                            ██╗
                                                            ██║


            ";


            string esqueleto1 = @"





                                    ██╗                   ██████╗ 
                                    ██║                  ██╔═══██╗
                                    ██║                  ██║   ██║
                                    ██║                  ██║   ██║
                                    ██║                  ╚██████╔╝
                                    ╚═╝                   ╚═════╝                          
            ";


             string esqueleto2 = @"





                                    ██╗                   ██████╗ 
                                    ██║                  ██╔═══██╗
                                    ██║                  ██║   ██║
                                    ██║                  ██║   ██║
                                    ██║                  ╚██████╔╝
                                    ╚═╝                   ╚═════╝     
                                    ██╗                     ██╗
                                    ██║                     ██║
                                    ██║                     ██║
                                    ██║                     ██║ 
                                    ██║                     ██║        
                                    ╚═╝                                     
            ";


            string esqueleto3 = @" 





                                    ██╗                   ██████╗ 
                                    ██║                  ██╔═══██╗
                                    ██║                  ██║   ██║
                                    ██║                  ██║   ██║
                                    ██║                  ╚██████╔╝
                                    ╚═╝                   ╚═════╝     
                                    ██╗                  ██╗██╗
                                    ██║                 ██╔╝██║
                                    ██║                ██╔╝ ██║
                                    ██║               ██╔╝  ██║ 
                                    ██║              ██╔╝   ██║        
                                    ╚═╝              ╚═╝                                                       
            ";


            string esqueleto4 = @" 





                                    ██╗                   ██████╗ 
                                    ██║                  ██╔═══██╗
                                    ██║                  ██║   ██║
                                    ██║                  ██║   ██║
                                    ██║                  ╚██████╔╝
                                    ╚═╝                   ╚═════╝     
                                    ██╗                  ██╗██╗██╗
                                    ██║                 ██╔╝██║ ██║
                                    ██║                ██╔╝ ██║  ██║
                                    ██║               ██╔╝  ██║   ██║
                                    ██║              ██╔╝   ██║    ██║   
                                    ╚═╝              ╚═╝           ╚═╝                                              
            ";


            string esqueleto5 = @" 





                                    ██╗                   ██████╗ 
                                    ██║                  ██╔═══██╗
                                    ██║                  ██║   ██║
                                    ██║                  ██║   ██║
                                    ██║                  ╚██████╔╝
                                    ╚═╝                   ╚═════╝  
                                    ██╗                  ██╗██╗██╗
                                    ██║                 ██╔╝██║ ██║
                                    ██║                ██╔╝ ██║  ██║
                                    ██║               ██╔╝  ██║   ██║
                                    ██║              ██╔╝   ██║    ██║   
                                    ╚═╝              ╚═╝    ██║    ╚═╝        
                                    ██╗                     ██║
                                    ██║                    ████
                                    ██║                  ██╔╝
                                    ██║                 ██╔╝
                                    ██║                ██╔╝
                                    ╚═╝               ██╔╝
                                                      ╚═╝                                                  
            ";
            string esqueleto6 = @" 





                                    ██╗                   ██████╗ 
                                    ██║                  ██╔═══██╗
                                    ██║                  ██║   ██║
                                    ██║                  ██║   ██║
                                    ██║                  ╚██████╔╝
                                    ╚═╝                   ╚═════╝
                                    ██╗                  ██╗██╗██╗
                                    ██║                 ██╔╝██║ ██║
                                    ██║                ██╔╝ ██║  ██║
                                    ██║               ██╔╝  ██║   ██║
                                    ██║              ██╔╝   ██║    ██║   
                                    ╚═╝              ╚═╝    ██║    ╚═╝        
                                    ██╗                     ██║
                                    ██║                   ██████
                                    ██║                 ██╔╝   ║██
                                    ██║                ██╔╝     ║██
                                    ██║               ██╔╝       ║██
                                    ╚═╝              ██╔╝         ║██
                                                     ╚═╝          ╚═╝                                                
            ";

             string base_desenho = @"
             
                                    ██╗
                                    ██║
                                    ██║
                                    ██║
                                    ██║                                            
                                    ███████ ███████ ███████ ███████
            ";


            switch (erros)
            {
                case 0: Console.SetCursorPosition(ScreenSizeW, ScreenSizeH + 7);Console.WriteLine(topo_desenho);break;
                case 1: Console.SetCursorPosition(ScreenSizeW, ScreenSizeH + 11);Console.WriteLine(esqueleto1); break;
                case 2: Console.SetCursorPosition(ScreenSizeW, ScreenSizeH + 11);Console.WriteLine(esqueleto2); break;
                case 3: Console.SetCursorPosition(ScreenSizeW, ScreenSizeH + 11);Console.WriteLine(esqueleto3); break;
                case 4: Console.SetCursorPosition(ScreenSizeW, ScreenSizeH + 11);Console.WriteLine(esqueleto4); break;
                case 5: Console.SetCursorPosition(ScreenSizeW, ScreenSizeH + 11);Console.WriteLine(esqueleto5); break;
                case 6: Console.SetCursorPosition(ScreenSizeW, ScreenSizeH + 11);Console.WriteLine(esqueleto6);Console.SetCursorPosition(ScreenSizeW, ScreenSizeH + 30);Console.WriteLine(base_desenho); break;
            }

        }



        static void Letreiro()
            {
                try{
                    int screenSize = Console.WindowWidth / 2;
                    int ScreenSizeH = Console.WindowHeight / 3;
                    string jogos = @"
                                                ██████╗ ███████╗███╗   ███╗      ██╗   ██╗██╗███╗   ██╗██████╗  ██████╗
                                                ██╔══██╗██╔════╝████╗ ████║      ██║   ██║██║████╗  ██║██╔══██╗██╔═══██╗
                                                ██████╔╝█████╗  ██╔████╔██║█████╗██║   ██║██║██╔██╗ ██║██║  ██║██║   ██║
                                                ██╔══██╗██╔══╝  ██║╚██╔╝██║╚════╝╚██╗ ██╔╝██║██║╚██╗██║██║  ██║██║   ██║
                                                ██████╔╝███████╗██║ ╚═╝ ██║       ╚████╔╝ ██║██║ ╚████║██████╔╝╚██████╔╝

                    ";
                    Console.Clear();
                    Console.SetCursorPosition(0, ScreenSizeH);
                    Console.WriteLine(jogos);
                    Console.ReadKey();
                    Console.Clear();
                }
                catch(Exception){
                    Console.WriteLine("Por favor deixe o programa em tela cheia!");
                    Console.ReadKey();
                }
                
            }
            


            static void win()
            {
                int screenSize = Console.WindowWidth / 2;
                int ScreenSizeH = Console.WindowHeight / 3;
                string jogos = @"
                                                ________  ________  ________  ________  ________  _______   ________   ________      
                                                |\   __  \|\   __  \|\   __  \|\   __  \|\   __  \|\  ___ \ |\   ___  \|\   ____\     
                                                 \ \  \|\  \ \  \|\  \ \  \|\  \ \  \|\  \ \  \|\ /\ \   __/|\ \  \\ \  \ \  \___|_    
                                                  \ \   ____\ \   __  \ \   _  _\ \   __  \ \   __  \ \  \_|/_\ \  \\ \  \ \_____  \   
                                                   \ \  \___|\ \  \ \  \ \  \\  \\ \  \ \  \ \  \|\  \ \  \_|\ \ \  \\ \  \|____|\  \  
                                                    \ \__\    \ \__\ \__\ \__\\ _\\ \__\ \__\ \_______\ \_______\ \__\\ \__\____\_\  \ 
                                                     \|__|     \|__|\|__|\|__|\|__|\|__|\|__|\|_______|\|_______|\|__| \|__|\_________\
                                                                                                                            \|_________|
                                                                                        
                                                                                        
                                                                                
                                                                                

            ";
                Console.Clear();
                Console.SetCursorPosition(0, ScreenSizeH);
                Console.WriteLine(jogos);
                Console.ReadKey();
            }



            static void gameOver()
            {
                int screenSize = Console.WindowWidth / 2;
                int ScreenSizeH = Console.WindowHeight / 3;
                string gameover = @"

                                                 ██████╗  █████╗ ███╗   ███╗███████╗     ██████╗ ██╗   ██╗███████╗██████╗ 
                                                ██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔═══██╗██║   ██║██╔════╝██╔══██╗
                                                ██║  ███╗███████║██╔████╔██║█████╗      ██║   ██║██║   ██║█████╗  ██████╔╝
                                                ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║   ██║╚██╗ ██╔╝██╔══╝  ██╔══██╗
                                                ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ╚██████╔╝ ╚████╔╝ ███████╗██║  ██║
                                                ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝     ╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═╝
                                                                                                        

            ";
                Console.Clear();
                Console.SetCursorPosition(0, ScreenSizeH);
                Console.WriteLine(gameover);
                Console.ReadKey();

            }


            static void tabela(int pontuação, int erros){

                int ScreenSizeH = Console.WindowWidth / 5;
                int ScreenSizeV = Console.WindowHeight / 5;
                
                string tabela = @"

                                                                                              
                                                                              
                                                        █████╗█████╗█████╗█████╗█████╗
                                                        ╚════╝╚════╝╚════╝╚════╝╚════╝
                                                        ██╗
                                                        ██║
                                                        ██║
                                                        ██║
                                                        ╚═╝
                                                        ███████ ███████ ███████ ██████                                                                                
                                                                                
                                                                                

                                                                                
                                                                        
                                                                              
                                                                              
                ";
                
                Console.SetCursorPosition(ScreenSizeH + 5, 7);
                Console.WriteLine($"Acertos  ---   {pontuação}");
                Console.SetCursorPosition(ScreenSizeH + 5, 9);
                Console.WriteLine($"Erros    ---   {erros}");
                Console.SetCursorPosition(ScreenSizeH, 0);
                Console.WriteLine(tabela);
            }


            static void Centralizar(string msg, int lg, int altura)
            {
                int ScreenSizeH = Console.WindowWidth / 5;
                int ScreenSizeV = Console.WindowHeight / 5;

                Console.SetCursorPosition(ScreenSizeH + lg, ScreenSizeV + altura);
                Console.WriteLine(msg);
            }


             static string ObterEntradaValida(){

                int ScreenSizeH = Console.WindowWidth / 5;
                int ScreenSizeV = Console.WindowHeight / 5;
                string entrada;

                while(true){
                    

                    Centralizar("Deseja continuar: sim[S] não[N]", 25, 26);
                    Console.SetCursorPosition(ScreenSizeH + 25, ScreenSizeV + 27);
                    entrada = Console.ReadLine().ToLower();

                    // Verificação da resposta do usuário

                    if(!String.IsNullOrWhiteSpace(entrada) && !String.IsNullOrEmpty(entrada) && (entrada =="s" || entrada == "n")){
                        return entrada;
                    }else{

                        //Mensagem de erro

                        Centralizar("Erro! Digite sim[S] ou não[N]", 25, 26);
                    }

                }
             }


             static int escolha_Forca(){

                int ScreenSizeH = Console.WindowWidth / 5;
                int ScreenSizeV = Console.WindowHeight / 5;
                string entrada;
                bool sucess;

                while(true){

                    Centralizar("[1] Contra máquina", 30, 0);
                    Centralizar("[2] Jogador contra jogador", 30, 1);
                    Centralizar("Qual desafio deseja: ", 30, 2);
                    Console.SetCursorPosition(ScreenSizeH + 30, ScreenSizeV + 3);
                    entrada = Console.ReadLine();
                    sucess = int.TryParse(entrada, out int num);

                    //Verificação da resposta do usuário

                    if(!String.IsNullOrEmpty(entrada) && !String.IsNullOrWhiteSpace(entrada) && sucess && 1 <= num && num <= 2){
                        return num;
                    }else{
                        Centralizar("Erro! Digite um número válido entre 1 e 2.", 30, 4);
                    }
                }
             }





            static int GerarPalavra(){

                Random random = new Random();
                int senha = random.Next(0, 13); // Atribuição de números gerados de 0 a 9
                return senha;
            }






            static void jogo1(){
                while(true){
                    string escolha, resp, palavra_esc;
                    int acertos = 0, erros = 0, pos = 0;
                    char letra;
                    int ScreenSizeW = Console.WindowWidth / 5;
                    int ScreenSizeH = Console.WindowHeight / 5;



                    // Vetor para armazenar as palavras
                    string[] palavras = {
                        "heroi", "bola de volei", "matagal", "arthur",
                        "volei", "fonte de agua", "prefeitura", "roupa",
                        "inquestionavel", "responsabilidade", "desproporcional",
                        "anticonstitucional", "intransigencia", "imprescindivel",
                    };


    




                    Letreiro();


                    DesenhaForca(erros);


                    // Palavra gerada
                    int index = GerarPalavra();
                    palavra_esc = palavras[index]; 
                    
                    // Vetor para letras já digitadas
                    List<char> letrasDigitadas = new List<char>();


                    // Limpa a tela imediatamente após o jogador 1 digitar a palavra
                    Console.Clear();
                    Letreiro();
                    DesenhaForca(erros);



                    // Inicia a palavra a ser exibida como traços
                    char[] palavraExibida = new string('_', palavra_esc.Length).ToCharArray();

                    for (int i = 0; i < palavra_esc.Length; i++)
                    {
                        if (palavra_esc[i] == ' ')
                        {
                            palavraExibida[i] = ' ';
                        }
                    }


                    // Exibe os traços da palavra
                    int cont = 30;
                    for (int c = 0; c < palavra_esc.Length; c++)
                    {
                        Console.SetCursorPosition(ScreenSizeW + cont, ScreenSizeH + 25);
                        Console.Write(palavraExibida[c]);
                        cont++;
                    }

                    // O segundo jogador tenta adivinhar a palavra
                    do
                    {

                        Centralizar("Digite um palpite de letra: ", 30, 23);
                        resp = Console.ReadLine().ToLower();


                        if (resp.Length == 1 && char.IsLetter(resp[0]))
                        {
                            letra = char.Parse(resp);

                            if(!letrasDigitadas.Contains(letra)){

                                letrasDigitadas.Add(letra);

                                if (palavra_esc.Contains(letra))
                                {

                                    // Substituir todas as ocorrências da letra correta

                                    for (int i = 0; i < palavra_esc.Length; i++)
                                    {
                                        if (palavra_esc[i] == letra)
                                        {
                                            palavraExibida[i] = letra;
                                            Console.SetCursorPosition(ScreenSizeW + 30 + i, ScreenSizeH + 25);
                                            Console.Write(letra);
                                            acertos++;
                                        }
                                    }
                                }else{

                                    // Se o palpite estiver errado

                                    erros++;
                                    DesenhaForca(erros);
                                }
                            }
                            
                            else
                            {

                                
                                Console.SetCursorPosition(ScreenSizeW + 30, ScreenSizeH + 24);
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Centralizar("Erro! Você já digitou essa letra.", 36, 24);
                                Console.ResetColor();
                                
                            }

                            Console.SetCursorPosition(ScreenSizeW + 30, ScreenSizeH + 28);
                            Console.WriteLine("Letras já digitadas: [ " + string.Join(", ", letrasDigitadas) + " ]");
                            }
                            else
                            {
                                // Se o input for inválido
                                Console.SetCursorPosition(ScreenSizeW + 30, ScreenSizeH + 24);
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Por favor, digite apenas uma letra válida.");
                                Thread.Sleep(1000);
                                Centralizar("                                   ", 30, 24);
                                continue;
                            }


                            // Exibe acertos e erros
                            tabela(acertos, erros);


                        } while (acertos < palavra_esc.Replace(" ", "").Length && erros < 6);



                        // Condições de vitória ou derrota
                        if (acertos == palavra_esc.Length)
                        {
                            Console.SetCursorPosition(ScreenSizeW + 30, ScreenSizeH + 26);
                            string vitoria = "Parabéns! Você acertou a palavra!";
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(vitoria);
                            Thread.Sleep(1500);
                            Console.ForegroundColor = ConsoleColor.White;
                            win();
                        }
                        else if (erros >= 6)
                        {
                            Console.SetCursorPosition(ScreenSizeW + 30, ScreenSizeH + 26);
                            string derrota = "Você perdeu! A palavra era: " + palavra_esc;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(derrota);
                            Thread.Sleep(1500);
                            Console.ForegroundColor = ConsoleColor.White;
                            gameOver();
                        }
                        string continuar = ObterEntradaValida(); 
                        if(continuar == "n"){
                            break;
                        }
                }

            }






             static void jogo2(){
                while(true){
                    string escolha, resp;
                    int acertos = 0, erros = 0, pos = 0;
                    char letra;
                    int ScreenSizeW = Console.WindowWidth / 5;
                    int ScreenSizeH = Console.WindowHeight / 5;



                    Letreiro();


                    DesenhaForca(erros);


                    // Primeiro jogador escolhe a palavra
                    Centralizar("Jogador 1, escolha uma palavra para o Jogador 2 adivinhar:", 24, 23);
                    escolha = Console.ReadLine().ToLower();



                    // Limpa a tela imediatamente após o jogador 1 digitar a palavra
                    Console.Clear();
                    Letreiro();
                    DesenhaForca(erros);



                    // Inicia a palavra a ser exibida como traços
                    char[] palavraExibida = new string('_', escolha.Length).ToCharArray();

                    for (int i = 0; i < escolha.Length; i++)
                    {
                        if (escolha[i] == ' ')
                        {
                            palavraExibida[i] = ' ';
                        }
                    }


                    // Exibe os traços da palavra
                    int cont = 30;
                    for (int c = 0; c < escolha.Length; c++)
                    {
                        Console.SetCursorPosition(ScreenSizeW + cont, ScreenSizeH + 25);
                        Console.Write(palavraExibida[c]);
                        cont++;
                    }

                    // O segundo jogador tenta adivinhar a palavra
                    do
                    {

                        Centralizar("Digite um palpite de letra: ", 30, 23);


                        resp = Console.ReadLine().ToLower();

                        if (resp.Length == 1 && char.IsLetter(resp[0]))
                        {
                            letra = char.Parse(resp);

                            if (escolha.Contains(letra))
                            {
                                // Substituir todas as ocorrências da letra correta
                                for (int i = 0; i < escolha.Length; i++)
                                {
                                    if (escolha[i] == letra)
                                    {
                                        palavraExibida[i] = letra;
                                        Console.SetCursorPosition(ScreenSizeW + 30 + i, ScreenSizeH + 25);
                                        Console.Write(letra);
                                        acertos++;
                                    }
                                }
                            }
                            else
                            {
                                // Se o palpite estiver errado
                                
                                Console.SetCursorPosition(ScreenSizeW + 30, ScreenSizeH + 24);
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Centralizar("Erro!", 30, 24);
                                Console.SetCursorPosition(ScreenSizeW + 36, ScreenSizeH + 24);
                                Console.ForegroundColor = ConsoleColor.White;
                                Centralizar("A letra não está na palavra.", 36, 24);
                                erros++;
                                DesenhaForca(erros);
                            }
                        }
                        else
                        {
                            // Se o input for inválido
                            Console.SetCursorPosition(ScreenSizeW + 30, ScreenSizeH + 24);
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Por favor, digite apenas uma letra válida.");
                            Thread.Sleep(1000);
                            Centralizar("                                   ", 30, 24);
                            continue;
                        }


                        // Exibe acertos e erros
                        tabela(acertos, erros);


                        } while (acertos < escolha.Length && erros < 6);



                        // Condições de vitória ou derrota
                        if (acertos == escolha.Length)
                        {
                            Console.SetCursorPosition(ScreenSizeW + 30, ScreenSizeH + 26);
                            string vitoria = "Parabéns! Você acertou a palavra!";
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(vitoria);
                            Thread.Sleep(1500);
                            Console.ForegroundColor = ConsoleColor.White;
                            win();
                        }
                        else if (erros >= 6)
                        {
                            Console.SetCursorPosition(ScreenSizeW + 30, ScreenSizeH + 26);
                            string derrota = "Você perdeu! A palavra era: " + escolha;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(derrota);
                            Thread.Sleep(1500);
                            Console.ForegroundColor = ConsoleColor.White;
                            gameOver();
                        }
                        string continuar = ObterEntradaValida();
                        if(continuar == "n"){
                            break;
                        }
                }
            }


            
    }
}
