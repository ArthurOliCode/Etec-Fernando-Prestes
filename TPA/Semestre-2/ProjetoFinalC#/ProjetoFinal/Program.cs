
namespace MenuPrincipal
{
    class Program
    {

        static void Main(string[] args){

           
            Centralizar(LetreiroMenu(), 20, -5);
            Centralizar(OpcoesMenu(), 20, 5);


            Console.ReadKey();
            try{
                escolhaMenu();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Por favor, deixe o programa em tela cheia!\n\n");
                Console.WriteLine($"Erro: {ex.Message}\n");
                Console.WriteLine($"Detalhes: {ex.StackTrace}");
                Console.ReadKey();
            }

            
            



            static string LetreiroMenu()
            {
                string menu = @"
                                                ███╗   ███╗███████╗███╗   ██╗██╗   ██╗
                                                ████╗ ████║██╔════╝████╗  ██║██║   ██║
                                                ██╔████╔██║█████╗  ██╔██╗ ██║██║   ██║
                                                ██║╚██╔╝██║██╔══╝  ██║╚██╗██║██║   ██║
                                                ██║ ╚═╝ ██║███████╗██║ ╚████║╚██████╔╝
                                                ╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ 
                                        
                ";
                Console.Clear();
                return menu;
            }

            static string OpcoesMenu()
            {
                string opcoes = @"
                                                                                                                    
                                                                            
                                █████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗
                                ╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝
                                ██╗                                                                  ██╗   
                                ██║          ███████╗ ██████╗ ██████╗  ██████╗ █████╗                ██║
                                ██║          ██╔════╝██╔═══██╗██╔══██╗██╔════╝██╔══██╗               ██║
                                ██║          █████╗  ██║   ██║██████╔╝██║     ███████║               ██║
                                ██║          ██╔══╝  ██║   ██║██╔══██╗██║     ██╔══██║               ██║
                                ╚═╝          ██║     ╚██████╔╝██║  ██║╚██████╗██║  ██║               ╚═╝
                                ██╗          ╚═╝      ╚═════╝ ╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝               ██╗ 
                                ██║                                                                  ██║
                                ██║                                                                  ██║
                                ██║                                                                  ██║
                                ██║                                                                  ██║
                                ╚═╝          ███████╗███████╗███╗   ██╗██╗  ██╗ █████╗               ╚═╝                                      
                                ██╗          ██╔════╝██╔════╝████╗  ██║██║  ██║██╔══██╗              ██╗ 
                                ██║          ███████╗█████╗  ██╔██╗ ██║███████║███████║              ██║
                                ██║          ╚════██║██╔══╝  ██║╚██╗██║██╔══██║██╔══██║              ██║
                                ██║          ███████║███████╗██║ ╚████║██║  ██║██║  ██║              ██║
                                ██║          ╚══════╝╚══════╝╚═╝  ╚═══╝╚═╝  ╚═╝╚═╝  ╚═╝              ██║
                                ╚═╝                                                                  ╚═╝ 
                                █████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗
                                ╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝                                                                      
                ";
                return opcoes;
            }


            static void escolhaMenu(){
                while(true){
                    Centralizar("Faça sua escolha, para qual jornada deseja ir?",-20, 31);
                    Centralizar("(1) Forca",-20, 32);
                    Centralizar("(2) Senha",-20, 33);

                    int respV = int.Parse(EntradaValida());
                    if(respV == 1){
                        Console.Clear();
                        Forca1_2.Jogo_Forca();
                    }else{
                        Console.Clear();
                        SenhaAdv.Jogo_Senha();
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

            
            static string EntradaValida(){

                string entrada;
                bool sucess;

                while(true){
                    Console.Clear();
                    Centralizar(LetreiroMenu(), 20, -5);
                    Centralizar(OpcoesMenu(), 20, 5);
                    Centralizar("Faça sua escolha, para qual jornada deseja ir?",-20, 32);
                    Centralizar("(1) Forca",-20, 33);
                    Centralizar("(2) Senha",-20, 34);

                    
                    Console.SetCursorPosition(36, 46);
                    entrada = Console.ReadLine();
                    sucess = int.TryParse(entrada, out int num);

                    // Verificação se a resposta é nula, ou se ela não se encaixa como int
                    if(!String.IsNullOrEmpty(entrada) && sucess && 1 <= num && num <= 2 && entrada.All(char.IsDigit)){
                        return entrada;
                    }else{
                        Centralizar("Erro! Por favor digite um número válido entre 1 e 2!",-20, 36);
                        Centralizar("Digite sua opção: ",-20, 32);
                    }
                }
            }
        }
    }
}
