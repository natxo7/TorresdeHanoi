using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        int movimientos = 0;
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            if (a.isEmpty() == true)
            {
                Disco enMovimiento = b.pop();
                Console.WriteLine("mov si a es vacio");
                a.push(enMovimiento);
               
            }
            else if (b.isEmpty() == true)
            {
                Disco enMovimiento = a.pop();
                Console.WriteLine("mov si b es vacio");
                b.push(enMovimiento);
               
            }
            else if (a.elementos[a.elementos.Count-1].Valor > b.elementos[b.elementos.Count - 1].Valor)
            {
                Disco enMovimiento = b.pop();
                Console.WriteLine("mov si a > que b ");
                a.push(enMovimiento);
            }
            else
            {
                Disco enMovimiento = a.pop();
                Console.WriteLine("mov si a < que b ");
                b.push(enMovimiento);
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            bool seguirBucle=true;
            if(n%2 != 0)//para si son impares
            {
                Console.WriteLine(" ES IMPAR");
                while (seguirBucle==true)//mientras que no esten todos en la ultima columna haz esto
                {

                    if (fin.Size < n)
                    {
                        mover_disco(ini, fin);//movimiento de ini a fin
                        movimientos = movimientos + 1;//sumamos 1 movimiento
                    }


                    if (fin.Size < n)
                    {
                        mover_disco(ini, aux);//movimiento de ini a aux
                        movimientos = movimientos + 1;//sumamos 1 movimiento
                    }

                    if (fin.Size < n)
                    {

                        mover_disco(aux, fin);//movimiento de aux a fin
                        movimientos = movimientos + 1;//sumamos 1 movimient
                    }
                    if (fin.Size == n)
                    {
                        seguirBucle = false;
                       
                    }
                }
               

            }
            else//el caso para cuando sean pares
            {
                Console.WriteLine("ES PAR");
                while (seguirBucle == true)
                {
                    if (fin.Size < n)
                    {
                        mover_disco(ini, aux);//movimiento de ini a aux
                        movimientos++;//sumamos 1 movimiento
                    }
                    if (fin.Size < n)
                    {
                        mover_disco(ini, fin);//movimiento de ini a fin
                        movimientos++;//sumamos 1 movimiento
                    }
                    if (fin.Size < n)
                    {
                        mover_disco(aux, fin);//movimiento de aux a fin
                        movimientos++;//sumamos 1 movimiento
                    }
                    if (fin.Size == n)
                    {
                        seguirBucle = false;
                      
                    }
                }
            }
            return movimientos;
        }
    }
   
}
