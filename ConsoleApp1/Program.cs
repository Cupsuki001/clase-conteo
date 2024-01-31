using ConsoleApp1;
public class SimFact
{
    public static void Main(String[] args)
    {
        Factura f = new Factura();
        double[,] fa = new double[40, 5];
        int alm, fila, col, ap = 0, rp = 0 , sal;
        do
        {


            do
            {
                ap = 0;
                rp = 0;
                Console.WriteLine("-------------------------------------------------");
                alm = f.validar("Digite la cantidad de estudiantes a evaluar:  ");
                Console.WriteLine("///////////////////////////////////////////////");

            } while (alm <= 0 || alm > 40);

            for (fila = 0; fila < alm; fila++)
            {

                Console.WriteLine("Ingrese las Notas del estudiante #" + (1 + fila));

                do
                {

                    fa[fila, 0] = f.validar("Nota 1 :");
                    f.setFact(fa);
                } while (fa[fila, 0] < 0 || fa[fila, 0] > 25);

                do
                {

                    fa[fila, 1] = f.validar("Nota 2 :");
                    f.setFact(fa);
                } while (fa[fila, 0] < 0 || fa[fila, 0] > 25);

                do
                {

                    fa[fila, 2] = f.validar("Nota 3 :");
                    f.setFact(fa);
                } while (fa[fila, 2] < 0 || fa[fila, 2] > 25);

                do
                {

                    fa[fila, 3] = f.validar("Nota 4 :");
                    f.setFact(fa);
                } while (fa[fila, 3] < 0 || fa[fila, 3] > 25);

                Console.WriteLine("------------------------------------//");


                fa[fila, 4] = fa[fila, 0] + fa[fila, 1] + fa[fila, 2] + fa[fila, 3];

            }
            Console.WriteLine("-------------------RESULTADOS--------------------");
            for (fila = 0; fila < alm; fila++)
            {
                for (col = 0; col < 5; col++)
                {

                    if (fa[fila, 4] >= 60)
                    {
                        Console.Write("\t" + fa[fila, col]);

                    }
                    else
                    {
                        Console.Write("\t" + fa[fila, col]);

                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------------");
            for (fila = 0; fila < alm; fila++)
            {
                if (fa[fila, 4] >= 60)
                {
                    Console.WriteLine("\t" + "Estudiante #" + (1 + fila) + " Aprobo" + "  Nota: " + fa[fila, 4]);
                    ap++;

                }
                else
                {
                    Console.WriteLine("\t" + "Estudiante #" + (1 + fila) + " Reprobo" + " Nota: " + fa[fila, 4]);
                    rp++;

                }
            }
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("\t" + "TOTAL Ingresados: " + alm);
            Console.WriteLine("\t" + "Aprobados: " + ap);
            Console.WriteLine("\t" + "Reprobados: " + rp);
            Console.WriteLine("-------------------------------------------------");
            do
            {
                sal = f.validar("Desea seguir en el programa? 1.Si 2.No" + "\t");

            } while (sal <= 0 || sal > 2);

        } while (sal == 1);
        Console.WriteLine("Buen dia :)");
        Console.ReadKey();
    
    }   
    
    
}