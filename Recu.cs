using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRecursivosSLE26Sep
{
    internal class Recu
    {
        //PARA UN EJERCICIO RECURSIVO SE NECESITA QUE SE LLAME AL MISMO M
        public int NumeroDescendente(int numeroUsuario)
        {
           
                
            if (numeroUsuario == 0)
            {
                return numeroUsuario;
            }

            Console.WriteLine(numeroUsuario);

            return  NumeroDescendente(numeroUsuario-1);

        }

        public int NumeroAscedente(int numeroUsuario1)
        {
            if (numeroUsuario1==0)
            {
                return numeroUsuario1;
            }
            Console.WriteLine(numeroUsuario1);
            return NumeroAscedente(numeroUsuario1+1);
        }

    }





    
}
