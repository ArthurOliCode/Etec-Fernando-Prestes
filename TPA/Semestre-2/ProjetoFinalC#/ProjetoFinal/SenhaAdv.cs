
namespace MenuPrincipal{
    // See https://aka.ms/new-console-template for more information
    using System.ComponentModel;
    using System.Runtime.InteropServices;
    using System.Security.Cryptography.X509Certificates;
    using System.Security.Principal; //Metódo usado para resgatar o método DllImport do Kernell
    internal class SenhaAdv
    {

        //Importação das funções GetConsoleWindow e ShadowWindow, da DLL do kernell32.dll e DLL user32.dll

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool SetConsoleScreenBufferSize(IntPtr hConsoleOutput, COORD size);



        [StructLayout(LayoutKind.Sequential)]
        struct COORD
        {
            public short x;
            public short y;
            public COORD(short X, short Y)
            {
                X = x;
                Y = y;
            }
        }



        //Definição de uma constante para maximizar a tela do CMD

        const int Sw_Maximize = 3;
        const int STD_OUTPUT_HANDLE = -11;



        [DllImport("kernel32.dll", SetLastError = true)] static extern IntPtr GetStdHandle(int nStdHandle);




        public static void Jogo_Senha()
        {


            //Obtenção da janela do console

            IntPtr hwndConsole = GetConsoleWindow();


            //Maximização da janela do console

            ShowWindow(hwndConsole, Sw_Maximize);



            //Ajuste do tamanho do Buffer do console

            IntPtr handle = GetStdHandle(STD_OUTPUT_HANDLE);
            COORD newSize = new COORD(120, 300);
            SetConsoleScreenBufferSize(handle, newSize);


            // Randomização dos números para a criação da senha

            while(true){
                int ScreenSizeW = Console.WindowWidth / 5;
                int ScreenSizeH = Console.WindowHeight / 5;




                string respV;
                string senhaDigitada;

                int[] palpite = { 0, 0, 0, 0 };
                int num;
                int tentativas = 0;
                int correto = 0;
                int quase = 0;
                int errado = 0;

                const int TAMANHO_SENHA = 4;
                const int MAX_TENTATIVAS = 12;

                int[] chave = GerarSenha(TAMANHO_SENHA);
                





                //Metódo para a exibição do letreiro inicial utilizando a tablea ASCII

                Letreiro();
                Console.ReadKey();
                Console.Clear();


                //Metódo para fazer a introdução do jogo, com um mini diálogo e imagem em tabela ASCII

                caixaInterrogação();
                Introdução();


                Console.SetCursorPosition(ScreenSizeW + 24, ScreenSizeH + 28);
                Console.WriteLine("Digite seus palpites (insira 4 digítos): ");
                Console.SetCursorPosition(ScreenSizeW + 24, ScreenSizeH + 29);


                // Tratamento de erro caso o usuário digite menos de 4 números
                respV = ObterEntradaValida(TAMANHO_SENHA);
            


                // Conversão dos valores digitados de string para int

                for (int i = 0; i < respV.Length; i++)
                {
                    palpite[i] = int.Parse(respV[i].ToString());
                }
                Console.Clear();






                // Laço de repetição para validação do palpite
                while(correto <= 4 || tentativas < MAX_TENTATIVAS)
                {   
                    if(tentativas == MAX_TENTATIVAS - 1){
                        gameOver();
                        break;
                    }
                    tentativas += 1;


                    // Redefinição de valores
                    senhaDigitada = respV;
                    correto = 0;
                    quase = 0;
                    errado = 0;

                    // Laço de repetição para a classificação dos pontos
                    for(int i=0; i < TAMANHO_SENHA; i++){
                        if (palpite[i] == chave[i])
                        {
                            correto += 1;
                        }
                        else if(chave.Contains(palpite[i]) && chave[i] != palpite[i]){
                            quase += 1;
                        }else{
                            errado += 1;
                        }

                    }

                    if(correto == TAMANHO_SENHA){
                        Console.Clear();
                        win();
                        final();
                        Console.ReadKey();
                        break;
                    }

                    // Apresentação de dados para o usuário
                    ExibirResultado(correto, quase, errado, tentativas, MAX_TENTATIVAS, senhaDigitada);


                    // Novo palpite do usuário
                    Console.SetCursorPosition(ScreenSizeW + 24, ScreenSizeH + 28);
                    Console.WriteLine("Digite seus palpites (insira 4 digítos): ");
                    Console.SetCursorPosition(ScreenSizeW + 24, ScreenSizeH + 29);
                
                    // Tratamento de erro para a variável respV
                    respV = ObterEntradaValida(TAMANHO_SENHA);



                    // Conversão dos valores digitados de string para int
                    
                    for (int i = 0; i < respV.Length; i++)
                    {
                        palpite[i] = int.Parse(respV[i].ToString());
                    }
                    Console.Clear();



                }
                string continuar = ObterContinuarValido();
                if(continuar == "n"){
                    break;
                }
            }

            



            static void ExibirResultado(int correto, int quase, int errado, int tentativas, int maxTentativas, string senhaDigitada)
            {   

                int ScreenSizeW = Console.WindowWidth / 5;
                int ScreenSizeH = Console.WindowHeight / 5;


                Console.Clear();

                caixaInterrogação();

                Console.SetCursorPosition(ScreenSizeW - 8, ScreenSizeH + 28);
                Console.WriteLine(FormatarMensagem(correto, "Apenas um número correto", "Números corretos: "));
                Console.SetCursorPosition(ScreenSizeW - 8, ScreenSizeH + 29);
                Console.WriteLine(FormatarMensagem(quase, "Apenas um número na posição errada", "Números em posições incorretas: "));
                Console.SetCursorPosition(ScreenSizeW - 8, ScreenSizeH + 30);
                Console.WriteLine(FormatarMensagem(errado, "Apenas um número está incorreto", "Números errados: "));
                Console.SetCursorPosition(ScreenSizeW - 8, ScreenSizeH + 31);
                Console.WriteLine(FormatarMensagem(maxTentativas - tentativas, "Apenas um tentativa restante", "Tentativas restantes: ") + "/12");
                Console.SetCursorPosition(ScreenSizeW - 8, ScreenSizeH + 32);
                Console.WriteLine($"Senha Digitada: [{senhaDigitada}]");
                
            }



            static string FormatarMensagem(int quantidade, string singular, string plural)
            {
                return quantidade == 1 ? $"{singular}" : $"{plural} {quantidade}";
            }


            static int[] GerarSenha(int tamanho){

                Random random = new Random();
                int[] senha = new int[tamanho];
                for (int i = 0; i < tamanho; i++){

                    senha[i] = random.Next(0, 10); // Atribuição de números gerados de 0 a 9

                }
                return senha;
            }



            static string ObterEntradaValida(int tamanho){

                int ScreenSizeW = Console.WindowWidth / 5;
                int ScreenSizeH = Console.WindowHeight / 5;
                string entrada;


                while(true){
                    
                    Console.SetCursorPosition(ScreenSizeW - 9, ScreenSizeH + 24);
                    Console.WriteLine($"Digite {tamanho} números(Sem espaços entre eles): ");
                    Console.SetCursorPosition(ScreenSizeW - 9, ScreenSizeH + 26);

                    entrada = Console.ReadLine();

                    // Verificação se a entrada não é nula ou se possui o comprimento correto
                    if(!String.IsNullOrEmpty(entrada) && entrada.Length == tamanho && entrada.All(char.IsDigit)){
                        return entrada;
                    }else{

                        // Mensagem de Erro
                        Console.SetCursorPosition(ScreenSizeW - 9, ScreenSizeH + 25);
                        Console.WriteLine($"Erro! A deve ser inserido {tamanho} números válidos");
                    }
                }

            }



            static void Centralizar(string msg, int lg, int altura)
            {
                int ScreenSizeH = Console.WindowWidth / 5;
                int ScreenSizeV = Console.WindowHeight / 5;

                Console.SetCursorPosition(ScreenSizeH + lg, ScreenSizeV + altura);
                Console.WriteLine(msg);
            }



            static string ObterContinuarValido(){

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



            static void Introdução()
            {
                int screenSize = Console.WindowWidth / 5;
                int ScreenSizeH = Console.WindowHeight - 50;

                string txt = @"
                                                    Você está no InLock, nele você terá que adivinhar
                                                    a senha pré-determinada, para que assim, você descubra os
                                                    segredos da caixa de Pandora. Você terá apenas 12 tentativas,
                                                    após isso, a caixa voltará para o universo.

                                                    
            ";
            try{
                Console.SetCursorPosition(0, ScreenSizeH);
                Console.WriteLine(txt);
            }
            catch(Exception ex){
                Console.WriteLine("Por favor deixe o programa em tela cheia!\n\n\n");
                Console.WriteLine($"Erro: {ex.Message}\n");
                Console.WriteLine($"Detalhes: {ex.StackTrace}");
                Console.ReadKey();
            }
                

            }
            



            static void final()
            {
                int screenSize = Console.WindowWidth / 5;
                int ScreenSizeH = Console.WindowHeight - 25;

                string txt = @"
                                                    --------------------------------------------------------------------------------
                                                    |        Você conseguiu desenterrar todos os segredos escondidos                |
                                                    |       da caixa de Pandora, olhando para dentro dela, é possível               |
                                                    |       perceber que além da intensa e infinita escuridão, com seus             |
                                                    |       próprios olhos, você enxerga um pequeno e brilhante passárinho          |
                                                    |       que apesar de toda aquela solidão se encontra cantando lindamente.      |
                                                    |        Seu nome..... é Esperança.                                             |
                                                    |        Apesar de todos os seus problemas, nunca se esqueça, a esperança é     |
                                                    |       uma das melhores dadivas que possuimos.                                 |
                                                    ---------------------------------------------------------------------------------
            ";
                Console.SetCursorPosition(0, ScreenSizeH);
                Console.WriteLine(txt);

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
                }
                catch(Exception){
                    Console.WriteLine("Por favor deixe o programa em tela cheia!");
                    Console.ReadKey();
                }
                
            }



            static void caixaInterrogação()
            {
                try{
                    int screenSize = Console.WindowWidth / 2;
                    int ScreenSizeH = Console.WindowHeight / 5;
                    string jogos = @"
                                                        ███████╗███████╗███████╗███████╗███████╗███████╗███████╗
                                                        ╚══════╝╚══════╝╚══════╝╚══════╝╚══════╝╚══════╝╚══════╝
                                                        _ _                                               _ _ 
                                                        | | |                                             | | |    
                                                        | | | ██████╗     ██████╗     ██████╗     ██████╗ | | |
                                                        | | | ╚════██╗    ╚════██╗    ╚════██╗    ╚════██╗| | |
                                                        | | |   ▄███╔╝      ▄███╔╝      ▄███╔╝      ▄███╔╝| | |
                                                        | | |   ▀▀══╝       ▀▀══╝       ▀▀══╝       ▀▀══╝ | | |
                                                        | | |   ██╗         ██╗         ██╗         ██╗   | | |
                                                        | | |   ╚═╝         ╚═╝         ╚═╝         ╚═╝   | | |
                                                        |||||                                             ||||| 
                                                        
                                                        ███████╗███████╗███████╗███████╗███████╗███████╗███████╗
                                                        ╚══════╝╚══════╝╚══════╝╚══════╝╚══════╝╚══════╝╚══════╝

                    ";
                    Console.SetCursorPosition(0, ScreenSizeH);
                    Console.WriteLine(jogos);
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
                Console.SetCursorPosition(0, ScreenSizeH);
                Console.WriteLine(jogos);
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
                Console.SetCursorPosition(0, ScreenSizeH);
                Console.WriteLine(gameover);
                Console.ReadKey();

            }



        }
    }

}

