using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        int movimientos = 0;//variable que se utiliza para saber los movimientos totales
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            if (a.isEmpty() == true)//si a esta vacio
            {
                Disco enMovimiento = b.pop();
                Console.WriteLine("mov si a es vacio");//guardamos b enMovimiento
                a.push(enMovimiento);
               
            }
            else if (b.isEmpty() == true)//si b esta vacio
            {
                Disco enMovimiento = a.pop();//guardamos a enMovimiento
                Console.WriteLine("mov si b es vacio");
                b.push(enMovimiento);
               
            }
            else if (a.elementos[a.elementos.Count-1].Valor > b.elementos[b.elementos.Count - 1].Valor)//si el elemento a> b
            {
                Disco enMovimiento = b.pop();//guardamos b enMovimiento
                Console.WriteLine("mov si a > que b ");
                a.push(enMovimiento);
            }
            else
            {
                Disco enMovimiento = a.pop();//guardamos a enMovimiento
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
                        seguirBucle = false;//para para el while ya que seguir bucle es bool
                       
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
            return movimientos;//devolcemos los movimientos
        }
        //codigo recursivo ya listo
        public int recursivo(int n, Pila ini, Pila fin, Pila aux) 
        {
            if (n == 1) //condicion
            {

                mover_disco(ini, fin); 
                movimientos = movimientos + 1;
            }
            else // Si no
            {
                recursivo(n - 1, ini, aux, fin);
                mover_disco(ini, fin);
                movimientos = movimientos + 1;
                recursivo(n - 1, aux, fin, ini);
            }
            return movimientos; //devolvemos los moviminetos
        }
    }
   
}
