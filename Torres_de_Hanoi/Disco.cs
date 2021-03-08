using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Disco
    {
        //PODEMOS ELEGIR SI INT O STRING 
        //ESTE METODO ASIGNA LOS GET Y SET AUTOMATICAMENTE AL ATRIBUTO VALOR
         public int Valor { get; set; }
        public Disco(int valor)
        {
            Valor = valor;
        }

      
    }
}
