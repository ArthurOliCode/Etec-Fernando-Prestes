programa
{
	inclua biblioteca Util --> u
	inclua biblioteca Texto --> t
	inclua biblioteca Tipos --> tp


	funcao consulta_diaMes(){
		cadeia resp_usu, dia[8], mes[13], resp_num, resp_dm
		inteiro resp_nu
		faca{
			dia[0] = " "				mes[0] = " "
									mes[1] = "Janeiro"
			dia[1] = "Segunda-feira"		mes[2] = "Fevereiro"
			dia[2] = "Terça-feira"		mes[3] = "Março"
			dia[3] = "Quarta-feira"		mes[4] = "Abril"
			dia[4] = "Quinta-feira"		mes[5] = "Maio"
			dia[5] = "Sexta-feira"		mes[6] = "Junho"
			dia[6] = "Sábado"			mes[7] = "Julho"
			dia[7] = "Domingo"			mes[8] = "Agosto"
									mes[9] = "Setembro"
									mes[10] = "outubro"
									mes[11] = "Novembro"
									mes[12] = "Dezembro"

			limpa()
			escreva("\t\t\t\tConsulta Dia/Mês\n")
			escreva("\t\t\t--------------------\n\n\n")
	
			escreva("Informe um número de 1 à 12: ")
			leia(resp_num)
			enquanto(nao (tp.cadeia_e_inteiro(resp_num, 10))){
				escreva("\n\n\t\t\tErro!! Informe um número válido")
				u.aguarde(1000)
				limpa()
				escreva("\t\t\t\tConsulta Dia/Mês\n")
				escreva("\t\t\t--------------------\n\n\n")
	
				escreva("\n\n\t\t\tInforme um número de 1 à 12: ")
				leia(resp_num)
			}
			resp_nu = tp.cadeia_para_inteiro(resp_num, 10)
			
			limpa()
			escreva("\t\t\tDeseja consultar um dia da semana ou, um mês: [d/m] ")
			leia(resp_dm)
			resp_dm = t.caixa_baixa(resp_dm)
			enquanto(nao (t.extrair_subtexto(resp_dm, 0, 1) == "d") e nao (t.extrair_subtexto(resp_dm, 0, 1) == "m")){
				limpa()
				escreva("\n\n\t\t\tErro! Informe uma resposta válida!")
				u.aguarde(1000)
				limpa()
				escreva("\n\n\t\t\tDeseja consultar um dia da semana ou, um mês: [d/m]")
				leia(resp_dm)
				resp_dm = t.caixa_baixa(resp_dm)
			}

	
			se(t.extrair_subtexto(resp_dm, 0, 1) == "d"){
				se(resp_nu < 0 ou resp_nu > 7){
					escreva("\n\n\t\t\tErro! Resposta inválida")
					u.aguarde(1000)
					limpa()
				}senao{
					escreva("\n\n\t\t\tO número " + resp_nu + " coincide com o dia " + dia[resp_nu])
				}
			}senao se(t.extrair_subtexto(resp_dm, 0, 1) == "m"){
				se(resp_nu < 1 ou resp_nu > 12){
					escreva("\n\n\t\t\tErro! Resposta Inválida ")
					u.aguarde(1000)
					limpa()
				}senao{
					escreva("\n\n\t\t\tO número " + resp_nu + " coincide com o mês " + mes[resp_nu])
				}
			}

			escreva("\n\n\t\t\tDeseja continuar: [s/n] ")
			leia(resp_usu)
			resp_usu = t.caixa_baixa(resp_usu)
			
		}enquanto(t.extrair_subtexto(resp_usu, 0, 1) == "s")
	}
	

	
	funcao consulta_estados()
	{
		cadeia estados[27][2]
		cadeia consulta, resp_usu
		faca{
			estados[0][0] = "AC"  estados[0][1] = "Acre"
			estados[1][0] = "AL"  estados[1][1] = "Alagoas"
			estados[2][0] = "AP"  estados[2][1] = "Amapá"
			estados[3][0] = "AM"  estados[3][1] = "Amazonas"
			estados[4][0] = "BA"  estados[4][1] = "Bahia"
			estados[5][0] = "CE"  estados[5][1] = "Ceará"
			estados[6][0] = "DF"  estados[6][1] = "Distrito Federal"
			estados[7][0] = "ES"  estados[7][1] = "Espírito Santo"
			estados[8][0] = "GO"  estados[8][1] = "Goiás"
			estados[9][0] = "MA"  estados[9][1] = "Maranhão"
			estados[10][0] = "MT"  estados[10][1] = "Mato Grosso"
			estados[11][0] = "MS"  estados[11][1] = "Mato Grosso do Sul"
			estados[12][0] = "MG"  estados[12][1] = "Minas Gerais"
			estados[13][0] = "PA"  estados[13][1] = "Pará"
			estados[14][0] = "PB"  estados[14][1] = "Paraíba"
			estados[15][0] = "PR"  estados[15][1] = "Paraná"
			estados[16][0] = "PE"  estados[16][1] = "Pernambuco"
			estados[17][0] = "PI"  estados[17][1] = "Piauí"
			estados[18][0] = "RJ"  estados[18][1] = "Rio de Janeiro"
			estados[19][0] = "RN"  estados[19][1] = "Rio Grande do Norte"
			estados[20][0] = "RS"  estados[20][1] = "Rio Grande do Sul"
			estados[21][0] = "RO"  estados[21][1] = "Rondônia"
			estados[22][0] = "RR"  estados[22][1] = "Roraima"
			estados[23][0] = "SC"  estados[23][1] = "Santa Catarina"
			estados[24][0] = "SP"  estados[24][1] = "São Paulo"
			estados[25][0] = "SE"  estados[25][1] = "Sergipe"
			estados[26][0] = "TO"  estados[26][1] = "Tocantins"
	
	
			limpa()
			escreva("\t\t\t\tConsulta Estados\n")
			escreva("\t\t\t-----------------------------\n\n\n")
			
			escreva("\t\t\tInforme o estado ou sigla: ")
			leia(consulta)
	
			para(inteiro i=0; i<27; i++)
			{
				se(t.caixa_alta(consulta) == estados[i][0])
				{
					escreva("\n\t\t\tA sigla " + t.caixa_alta(consulta) + " coincide com o estado " + estados[i][1])
					pare
				}senao se(consulta==estados[i][1])
				{
					escreva("\n\t\t\tO estado " + consulta + " coincide com a sigla " + t.caixa_alta(estados[i][0]))
					pare
				}senao se(i == 26){
					escreva("\n\t\t\tEstado não cadastrado no sistema...\n")
				}
			}
			escreva("\n\n\t\t\tDeseja continuar: [s/n]  ")
			leia(resp_usu)
			resp_usu = t.caixa_baixa(resp_usu)
		}enquanto(t.extrair_subtexto(resp_usu, 0, 1) == "s")
	}


	
	funcao extenso_num(){

		
		cadeia resp_usu

		
		faca{
			cadeia unidade[20], dezena[10], centena[10], resp_num
			inteiro num, dez, uni, cen
	
	
			unidade[0] = "zero"			dezena[1] = "dez"				centena[1] = "cem"
			unidade[1] = "um"			dezena[2] = "vinte"				centena[2] = "duzentos"
			unidade[2] = "dois"			dezena[3] = "trinta"			centena[3] = "trezentos"
			unidade[3] = "três"			dezena[4] = "quarenta"			centena[4] = "quatrocentos"
			unidade[4] = "quatro"		dezena[5] = "cinquenta"			centena[5] = "quinhentos"
			unidade[5] = "cinco"		dezena[6] = "sessenta"			centena[6] = "seicentos"
			unidade[6] = "seis"			dezena[7] = "setenta"			centena[7] = "setecentos"
			unidade[7] = "sete"			dezena[8] = "oitenta"			centena[8] = "oitocentos"
			unidade[8] = "oito"			dezena[9] = "noventa"			centena[9] = "novecentos"
			unidade[9] = "nove"			
			unidade[11] = "onze"		
			unidade[12] = "doze"
			unidade[13] = "treze"
			unidade[14] = "quatorze"
			unidade[15] = "quinze"
			unidade[16] = "desseis"
			unidade[17] = "dessete"
			unidade[18] = "dezoito"
			unidade[19] = "dezenove"
	
	
	
			limpa()
			escreva("\t\t\t\tNúmeros por extenso\n")
			escreva("\t\t\t-----------------------------\n\n\n")
			
			escreva("\t\t\tInforme um número de 0 á 1000:  ")
			leia(resp_num)
			enquanto(nao(tp.cadeia_e_inteiro(resp_num, 10)) ou tp.cadeia_para_inteiro(resp_num, 10) > 1000
			ou tp.cadeia_para_inteiro(resp_num, 10) < 0){
				limpa()
				escreva("\n\n\t\t\tErro! Digite um número válido")
				u.aguarde(1000)
				limpa()
				escreva("\t\t\t\tNúmeros por extenso\n")
				escreva("\t\t\t-----------------------------\n\n\n")
			
				escreva("\t\t\tInforme um número de 0 á 100:  ")
				leia(resp_num)
			}
	
			num = tp.cadeia_para_inteiro(resp_num, 10)
			se((nao(num == 10)) e num < 20){
				escreva("\n\n\t\t\tO número digitado " + num + ", por extenso será " + unidade[num])
				u.aguarde(1000)
			}senao se(num == 10 ou num > 19 e num < 100){
				dez = num / 10
				uni = num % 10
				se(uni == 0){
					escreva("\n\n\t\t\tO número digitado " + num + ", por extenso será " + dezena[dez])
					u.aguarde(1000)
				}senao{
					escreva("\n\n\t\t\tO número digitado " + num + ", por extenso será " + dezena[dez] + " e " + unidade[uni])
					u.aguarde(1000)
				}
			}senao se(num >= 100 e num < 1000){
				cen = num / 100
				dez = (num / 10) % 10
				uni = num % 10
				se(uni == 0){
					escreva("\n\n\t\t\tO número digitado " + num + ", por extenso será " + centena[cen] + " e " + dezena[dez])
					u.aguarde(1000)
				}senao se(dez == 0 e uni == 0){
					escreva("\n\n\t\t\tO número digitado " + num + ", por extenso será " + centena[cen])
					u.aguarde(1000)
				}senao{
					escreva("\n\n\t\t\tO número digitado " + num + ", por extenso será " + centena[cen] + " e " + dezena[dez] + " e " + unidade[uni])
					u.aguarde(1000)
				}
			}senao se(num == 1000){
				escreva("\n\n\t\t\tO número digitado " + num + ", por extenso será mil! -_-")
				u.aguarde(1000)
			}

			
			escreva("\n\n\n\t\t\tDeseja continuar: [s/n] ")
			leia(resp_usu)
			resp_usu = t.extrair_subtexto(t.caixa_baixa(resp_usu), 0, 1)
			enquanto(nao (resp_usu == "s") e nao (resp_usu == "n")){
				limpa()
				escreva("\n\n\t\t\tErro! Digite uma resposta válida")
				u.aguarde(1500)
				limpa()

				escreva("\n\n\n\t\t\tDeseja continuar: [s/n] ")
				leia(resp_usu)
				resp_usu = t.extrair_subtexto(t.caixa_baixa(resp_usu), 0, 1)
			}
			
		}enquanto(resp_usu == "s")
		
	}



	funcao sorteio_nomes(){


		cadeia resp_usu
			
		
		faca{
			cadeia resp, candidatos[10], sorteados[10]
			inteiro sort, i=1, limite, numsort[10]
	

			limpa()
			escreva("\n\t\t\t---------------------------------------\n")
			escreva("\t\t\t\tBem vindo ao sistema sorteia \n")
			escreva("\t\t\t---------------------------------------\n")
	    		escreva("\n\t\t\tAté quantos candidatos você deseja sortear?(1-9): ")
	    		leia(resp)
	    		
	    		// tratamento para um possível erro de digitação
	    		enquanto(nao tp.cadeia_e_inteiro(resp, 10) ou tp.cadeia_para_inteiro(resp, 10) > 9){
	    			limpa()
	      		escreva("\nErro!! Por favor, digite um número válido de 1 a 9: ")
	      		u.aguarde(1000)
	      		limpa()
	      		escreva("\n\t\t\t---------------------------------------\n")
				escreva("\t\t\t\tBem vindo ao sistema sorteia \n")
				escreva("\t\t\t---------------------------------------\n")
	    			escreva("\n\n\t\t\tAté quantos candidatos você deseja sortear?(1-9): ")
	      		leia(resp)
	    		}
	    		
	    		//captação de dados
	        	u.aguarde(800) 
	        	
	        	//máximo de pessoas á cadastrar, selecionado pelo usuário
	        	limite = tp.cadeia_para_inteiro(resp, 10)
	        	
	        	//Número sorteado randomicamente
	    		sort = u.sorteia(0, limite)
	    		
	    		//Loop para cadastro dos nomes de candidatos
			para(inteiro c=0; c < limite; c++){
				escreva("\n\t\t\tDigite o nome do " + i + "° candidato: ")
				leia(resp)
				//Tratamento para erro de digitação
				enquanto(tp.cadeia_e_inteiro(resp, 10) ou tp.cadeia_e_real(resp) 
				ou tp.cadeia_e_logico(resp) ou tp.cadeia_e_caracter(resp)){
					limpa()
					escreva("\n\n\t\t\tErro! Por favor digite um nome válido!! \n")
					u.aguarde(1000)
					escreva("\n\n\t\t\tDigite novamente: ")
					leia(resp)
				}
				
				/*Mensagem de erro, caso o candidato posterior, 
				tenha o mesmo nome que o seu antecessor*/
				se(c > 0){
					enquanto(resp == candidatos[c - 1]){
						limpa()
						escreva("\n\n\t\t\tErro de registro! Por favor digite um candidato válido! \n")
						leia(resp)
						candidatos[c] = resp
					}
				}
			  	candidatos[c] = resp
				i++
			}
			i=1
			
			limpa()
		    	escreva("\n\t\t\t---------------------------------------\n")
		    	escreva("\t\t\t\tOrdem Inversa da lista de nomes \n")
		    	escreva("\t\t\t---------------------------------------\n\n")
		    	para(inteiro c = limite - 1; c >= 0; c--){
		     		escreva("\t\t\t\t"+ i + "° candidato: " + candidatos[c] + ";\n")
		     		i++
		     		u.aguarde(1000)
		    	}
		    	//Loop para cadastrar números de sorteio
			para(inteiro c=0; c < limite; c++){
				enquanto(candidatos[sort] == "#"){
					sort = u.sorteia(0, limite - 1)
				}
				sorteados[c] = candidatos[sort]
				candidatos[sort] = "#" 
			}
		    	i=1
		    	escreva("\n\n\t\t\t\t---------------------------------------\n")
		    	escreva("\t\t\t\t\tCandidatos sorteados\n")
		    	escreva("\t\t\t\t---------------------------------------\n\n")
		    	para(inteiro c = 0; c < limite; c++){
		    			escreva("\t\t\t"+ i + "° sorteado: " + sorteados[c] + ";\n")
		    			i++
		    			u.aguarde(1000)
		    	}


			escreva("\n\n\n\t\t\tDeseja continuar: [s/n] ")
			leia(resp_usu)
			resp_usu = t.extrair_subtexto(t.caixa_baixa(resp_usu), 0, 1)
			enquanto(nao (resp_usu == "s") e nao (resp_usu == "n")){
				limpa()
				escreva("\n\n\t\t\tErro! Digite uma resposta válida")
				u.aguarde(1500)
				limpa()

				escreva("\n\n\n\t\t\tDeseja continuar: [s/n] ")
				leia(resp_usu)
				resp_usu = t.extrair_subtexto(t.caixa_baixa(resp_usu), 0, 1)
			}
		    	
		}enquanto(resp_usu == "s")
	}



	funcao ordena_num(){

		
		cadeia resp_usu
		
		
		faca{
			
			inteiro num[10], cor, number
			cadeia resp_num, resp_cd


			limpa()
			escreva("\t\t\t\tOrdena Números\n")
			escreva("\t\t\t-----------------------------\n\n\n")

			para(inteiro i=0; i < 10; i++){
				
				escreva("\t\t\tInforme um número:  ")
				leia(resp_num)
				enquanto(nao(tp.cadeia_e_inteiro(resp_num, 10))){
					limpa()
					escreva("\n\n\t\t\tErro!! Digite um número válido")
					u.aguarde(1500)
					limpa()

					escreva("\t\t\t\tOrdena Números\n")
					escreva("\t\t\t-----------------------------\n\n\n")
					escreva("\n\n\t\t\tInforme um número:  ")
					leia(resp_num)
				}
				number = tp.cadeia_para_inteiro(resp_num, 10)
				num[i] = number
			}
	
				
				escreva("\t\t\t\n\nDeseja que a lista seja crescente ou decrescente: [c/d] ")
				leia(resp_cd)
				resp_cd = t.extrair_subtexto(t.caixa_baixa(resp_cd), 0, 1)
				enquanto(nao(resp_cd == "c") e nao(resp_cd == "d")){
					limpa()
					escreva("\n\n\t\t\tErro!! Digite resposta inválida")
					u.aguarde(1500)
					limpa()

					escreva("\t\t\t\n\nDeseja que a lista seja crescente ou decrescente: [c/d] ")
					leia(resp_cd)
					resp_cd = t.extrair_subtexto(t.caixa_baixa(resp_cd), 0, 1)
				}


				se(resp_cd == "c"){
					para(inteiro c=0; c < 10; c++){
						para(inteiro x=9; x > 0; x--){
							se(num[x] < num[x-1]){
								cor = num[x - 1]
								num[x - 1] = num[x]
								num[x] = cor 
							}							
						}
					}

					limpa()
					escreva("\t\t\t\tLista de Resultado\n")
					escreva("\t\t\t-----------------------------\n\n\n")
					para(inteiro n=0; n < 10; n++){
						escreva("\n\t\t\t" + num[n])
					}
					
				}senao se(resp_cd == "d"){
					para(inteiro c=0; c < 10; c++){
						para(inteiro x=9; x > 0; x--){
							se(num[x] > num[x-1]){
								cor = num[x - 1]
								num[x - 1] = num[x]
								num[x] = cor 
							}							
						}
					}

					limpa()
					escreva("\t\t\t\tLista de Resultado\n")
					escreva("\t\t\t-----------------------------\n\n\n")
					para(inteiro n=0; n < 10; n++){
						escreva("\n\t\t\t" + num[n])
					}
				}

				escreva("\n\n\n\t\t\tDeseja continuar: [s/n] ")
				leia(resp_usu)
				resp_usu = t.extrair_subtexto(t.caixa_baixa(resp_usu), 0, 1)
				enquanto(nao (resp_usu == "s") e nao (resp_usu == "n")){
					limpa()
					escreva("\n\n\t\t\tErro! Digite uma resposta válida")
					u.aguarde(1500)
					limpa()
	
					escreva("\n\n\n\t\t\tDeseja continuar: [s/n] ")
					leia(resp_usu)
					resp_usu = t.extrair_subtexto(t.caixa_baixa(resp_usu), 0, 1)
				}
		}enquanto(resp_usu == "s")
	}

	
	funcao menu()
	{
		cadeia resp_esc
		faca{
			
				escreva("\n\t\t\t--------------------------------------")
				escreva("\n\t\t\t\tMenu de escolhas")
				escreva("\n\t\t\t--------------------------------------")
				escreva("\n\t\t\t|__________________________________________|")
				escreva("\n\t\t\t|[1] Consulta Dia e Mês                    |")
				escreva("\n\t\t\t|[2] Consulte de Siglas e Estados          |")
				escreva("\n\t\t\t|[3] Extenso de um número de(0-1000)       |")
				escreva("\n\t\t\t|[4] Sorteio de Nomes                      |")
				escreva("\n\t\t\t|[5] Ordena números                        |")
				escreva("\n\t\t\t|[6] Sair                                  |")
				escreva("\n\t\t\t|__________________________________________|")
				escreva("\n\n\t\t\tDigite sua opção: ")
				leia(resp_esc)
				escolha(tp.cadeia_para_inteiro(resp_esc,10))
				{
					caso 1:
						consulta_diaMes()
						pare	
						
					caso 2:
						consulta_estados()
						pare
						
					caso 3:
						extenso_num()
						pare
						
					caso 4:
						sorteio_nomes()
						pare
					caso 5:
						ordena_num()
						pare
				}
			}enquanto(nao (t.extrair_subtexto(resp_esc, 0, 1) == "6"))
		}
	
	
	funcao inicio()
	{
		menu()
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 15770; 
 * @DOBRAMENTO-CODIGO = [7, 85, 148, 254, 370, 475];
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */