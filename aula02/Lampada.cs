using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula02
{
    public class Lampada
    {
        private bool ligada;

        public Lampada(bool ligada){
            this.ligada = ligada;
        }

        public void Ligar(
        ){
            this.ligada = true;
        }
        public void Desligar(){
            this.ligada = false;
        }

        public void Imprimir(){
            if(this.ligada == true){
                Console.WriteLine("Lâmpada Ligada");
            }else {
                Console.WriteLine("Lâmpada Desligada");
            }
        }
    }
}
