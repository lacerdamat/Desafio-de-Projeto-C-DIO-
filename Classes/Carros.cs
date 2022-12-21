using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento{
    public class Carro{
        public Carro(string placa, string modelo){
            placaDoCarro = placa;
            modeloDoCarro = modelo;

        }
        public string _placaDoCarro;
        public string _modeloDoCarro;
        public string placaDoCarro{ 
            get => _placaDoCarro.ToUpper(); 
            set{
                if (value == null || value.Length != 8){
                    Console.WriteLine("Insira um valor válido!");
                }
                else{
                    _placaDoCarro = value;
                }
            }
        }
        public string modeloDoCarro{ 
            get => _modeloDoCarro.ToUpper();
            set{
                if (value == null){
                    Console.WriteLine("Insira um modelo válido!");
                }
                else{
                    _modeloDoCarro = value;
                }
            } 
        }
    }
}