using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKataSecuenciaBinaria
{
    class Secuencia
    {
        private char[] entradaarray;
        public string retorno { get; set; }
        public Secuencia(string entrada)
        {
            entradaarray = new char[entrada.Length];
            
            entradaarray = entrada.ToCharArray();
            string retornoStr = Secuenciar().ToString();
            int retorno = Secuenciar();
            char[] secuenciaarray = new char[retorno];           
            
            for (int i = 0; i < retorno; i++)
            {
                secuenciaarray[i]  = entradaarray[i];                
            }
            String str =new String(secuenciaarray);

            Console.WriteLine("Longitud: " + retorno);
            Console.WriteLine("Secuencia: " + str);
            Console.Read();
        }

        private int Secuenciar()
        {
            int aux = entradaarray.Length / 2;
            while (!SonIguales(0, aux) && aux > 1)
            {
                aux--;
            }
            return aux;
        }        

        private bool SonIguales(int ini, int fin)
        {
            int longitud = fin - ini;
            if (longitud > 0)
            { 
                char[] entradaarrayIni = new char[fin - ini];
                char[] entradaarrayFin = new char[fin - ini];
                for (int i = ini; i < fin; i++)
                {
                    entradaarrayIni[i] = entradaarray[i];
                    entradaarrayFin[i] = entradaarray[i+longitud];
                }

                for (int i = 0; i < longitud; i++)
                {
                    if (entradaarrayIni[i] != entradaarrayFin[i])
                    { 
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        private bool ContieneLosDos(int ini, int fin)
        {
            if (Contiene('0', ini, fin)) 
                if (Contiene('1', ini, fin))
                {
                    return true;
                }
            return false;
        }

        private bool Contiene(char caracter,int ini,int fin)
        { 
            int pos = ini;
            while (entradaarray[pos] != caracter && pos<fin)
            {
                pos++;
                if (pos == fin - 1) return false;
            }
            return true;
        }


    }
}
