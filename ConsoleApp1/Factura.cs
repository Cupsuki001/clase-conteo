using System;
/*using System.Collections.Generic;*/
/*using System.Linq;*/
using System.Text;
/*using System.Threading.Tasks;*/

namespace ConsoleApp1 
{
   public class Factura
    {
        
        double[,] Fact = new double[40,5];

        public Factura() { }

        public Factura(double[,] Fact)
        {
            this.Fact = Fact;
        }

        public void setFact(double[,] Fact)
        {
            this.Fact = Fact;
        }

        public int validar(String Mensaje)
        {
            int num = 0, v;
            do
            {
                v = 1;
                try
                {
                    Console.Write(Mensaje);
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    v = 0;
                    Console.WriteLine("No se aceptan letras", error.Message);
                }
            } while (v == 0);
            return num;
        }

    }
}
