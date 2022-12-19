using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Estacionamento
{
    public class FuncoesdoEstacionamento
    {
        Dictionary<Carros, Carros> carrosParados = new Dictionary<Carros, Carros>();
        
        int esc = 0;
        public void IniciarSistem(){
            try{
                Console.Clear();
                Console.WriteLine("Bom dia, bem vindo ao nosso sistema de estacionamento, o que deseja fazer?");
                Console.WriteLine("\r\n 1 - Adicionar um carro; \r\n 2 - Remover um carro; \r\n 3 - Listar todos os carros; \r\n 4 - Encerrar o sistema.");
                esc = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch(esc){
                    case 1: AdiocionarCarro(); break;
                    case 2: RemoverCarro(); break;
                    case 3: ListarCarros(); break;
                    case 4: Console.WriteLine("Sistema encerrado com sucesso!");
                    Environment.Exit(0); break;
                }
            }
            catch(Exception){
                Console.WriteLine("Por conta de algum erro, o programa teve de ser reiniciado");

            }   
            finally{
                Console.WriteLine("Por favor, escolha umas das opções.");
                ReiniciarSistem();
            } 
        }
        public void ReiniciarSistem(){
            Console.WriteLine("Pressione qualquer tecla para continuar");
            if (Console.ReadLine()!= null){
                IniciarSistem();
            }
        }
        public void AdiocionarCarro(){
            Console.WriteLine("Por favor, escreva a placa do carro e modelo:");
            carrosParados.Add(Console.ReadLine(),Console.ReadLine());
            Console.WriteLine("Carro adicionado com sucesso!");
            ReiniciarSistem();
        }
        public void RemoverCarro(){
                foreach( KeyValuePair<string, string> s in carrosParados){
                    Console.WriteLine($"Placa: {s.Key} - {s.Value}");

                }
                Console.WriteLine("Por favor, escreva a placa do carro:");
                string CarroRemovido = Console.ReadLine();
                if (carrosParados.ContainsKey(CarroRemovido)){ 
                    carrosParados.Remove(CarroRemovido);
                    Console.WriteLine("Escreva a quantidade de horas que o carro ficou: ");
                    decimal hrs = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"O carro ficou por {hrs} horas. \r\nO total foi {5*hrs} reais. \r\nCarro removido com sucesso!");
                    ReiniciarSistem();
                }
                else{
                    Console.WriteLine("Escolha uma placa existente!\r\n ");
                    RemoverCarro();
                }
        }
        public void ListarCarros(){
            foreach( KeyValuePair<string, string> s in carrosParados){
                Console.WriteLine($"Placa: {s.Key} - {s.Value}");

            }
            ReiniciarSistem();

        }
    }
}
        
    
