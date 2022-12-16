using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class FuncoesdoEstacionamento
    {
        List<string> carrosParados = new List<string>();
        int esc = 0;
        public void IniciarSistem(){
            Console.Clear();
            Console.WriteLine("Bom dia, bem vindo ao nosso sistema de estacionamento, o que deseja fazer?");
            Console.WriteLine("\r\n 1 - Adicionar um carro; \r\n 2 - Remover um carro; \r\n 3 - Listar todos os carros; \r\n 4 - Encerrar o sistema.");
            esc = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch(esc){
                case 1: AdiocionarCarro(); break;
                case 2: RemoverCarro(); break;
                case 3: ListarCarros(); break;
                default: Console.WriteLine("Sistema encerrado com sucesso!"); break;
            }
            
        }
        public void ReiniciarSistem(){
            Console.WriteLine("Pressione qualquer tecla para continuar");
            if (Console.ReadLine()!= null){
                IniciarSistem();
            }
        }
        public void AdiocionarCarro(){
            Console.WriteLine("Por favor, escreva a placa do carro:");
            carrosParados.Add(Console.ReadLine());
            Console.WriteLine("Carro adicionado com sucesso!");
            ReiniciarSistem();
        }
        public void RemoverCarro(){
            Console.WriteLine("Por favor, escreva a placa do carro:");
            carrosParados.Remove(Console.ReadLine());
            Console.WriteLine("Escreva a quantidade de horas que o carro ficou: ");
            decimal hrs = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"O carro ficou por {hrs} horas. \r\nO total foi {5*hrs} reais. \r\nCarro removido com sucesso!");
            ReiniciarSistem();
        }
        public void ListarCarros(){
            foreach(string lista in carrosParados){
            Console.WriteLine(lista);
            }
            ReiniciarSistem();
        }

        
    }
}