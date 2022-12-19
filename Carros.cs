using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class Carros{
        public string _placaDoCarro;
        public string _modeloDoCarro;
        public string placaDoCarro { 
            get => _placaDoCarro.ToUpper(); 
            set{
                if (placaDoCarro == null && placaDoCarro.Length <7){
                    Console.WriteLine("Insira um valor válido!");
                }
                else{
                    _placaDoCarro = value;
                }
            }
        }
        public string modeloDoCarro { 
            get => _modeloDoCarro.ToUpper();
            set{
                if (modeloDoCarro == null){
                    Console.WriteLine("Insira um modelo válido!");
                }
                else{
                    _modeloDoCarro = value;
                }
            } 
        }
    }
}