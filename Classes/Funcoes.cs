using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class Funcoes
    {
            
        Dictionary<string, string> carrosParados = new Dictionary<string, string>();
        public void IniciarSistem(){
            Console.WriteLine("\r\nO que deseja fazer? \r\n1 - Adicionar um carro." +
            " \r\n2 - Remover um carro. \r\n3 - Listar todos os carros presentes. \r\n4 - Encerrar o sistema.");
            int esc = Convert.ToInt32(Console.ReadLine());
            switch(esc){
                case 1: AdicionarCarro(); break;
                case 2: RemoverrCarro(); break;
                case 3: ListarCarro(); break;
                case 4: Console.WriteLine("Programa encerrado com sucesso!"); Environment.Exit(0); break;
                default: Console.WriteLine("Escolha uma opção válida!"); break;
            }
        }

            public void ReiniciarSistem(){
            Console.WriteLine("Pressione uma tecla para continuar");
            if (Console.ReadLine != null){    
                Console.Clear();
                IniciarSistem(); 
            }


        }
        public void AdicionarCarro(){
            Console.Clear();
            Console.WriteLine("Escreve a placa e o modelo do carro");
            Console.WriteLine("Vale lembrar que uma placa de carro tem sete digitos e uma travessão no meio: ABC-1234");
            Carro car = new Carro(Console.ReadLine(),Console.ReadLine());
            carrosParados.Add(car.placaDoCarro, car.modeloDoCarro);
            Console.WriteLine("Carro adicionado com sucesso!");
            ReiniciarSistem();
        }
        public void RemoverrCarro(){
            ListarCarro();
            Console.WriteLine("Qual carro deseja remover?");
            carrosParados.Remove(Console.ReadLine());
            Console.WriteLine("Carro removido com sucesso!");
            ReiniciarSistem(); 
        }
        public void ListarCarro(){
            foreach(KeyValuePair<string, string> carrosListados in carrosParados){
                Console.WriteLine($"Placa: {carrosListados.Key}.  Modelo: {carrosListados.Value}");
            }
        }
    }
}