using System;

namespace Punto3tp7
{
    class Program
    {
        static void Main(string[] args)
        {
            float tmax, tmin,t1 ,t2,t3,t4,t5,t6,t7;
            int dmax, dmin;

            tmax = 0f;
            tmin = 0f;

            dmax = 0;
            dmin = 0;

            

            Console.WriteLine("Bienvenido al programa para hallar la temperatura maxima y temperatura minima de una semana");
            Console.ReadKey();
            Console.Clear();

            for(int i=1 ;i < 8; i++)
            {
                switch(i)
                {
                    case 1: 
                            Console.WriteLine("Ingrese la temperatura del dia Lunes: ");
                            t1 = Convert.ToSingle(Console.ReadLine());
                            if (t1 > tmax || tmax == 0)
                            {
                                tmax = t1;
                                dmax = i;
                            }
                            if (t1 < tmin || tmin == 0)
                            {
                                tmin = t1;
                                dmin = i;
                            }
                    break;

                    case 2: 
                            Console.WriteLine("Ingrese la temperatura del dia Martes: ");
                            t2 = Convert.ToSingle(Console.ReadLine());
                            if (t2 > tmax)
                            {
                                tmax = t2;
                                dmax = i;
                            }
                            
                            if (t2 < tmin)
                            {
                                tmin = t2;
                                dmin = i;
                            }


                    break;

                    case 3: 
                            Console.WriteLine("Ingrese la temperatura del dia Miercoles: ");
                            t3 = Convert.ToSingle(Console.ReadLine());
                            if (t3 > tmax)
                            {
                                tmax = t3;
                                dmax = i;
                            }
                            
                            if (t3 < tmin)
                            {
                                tmin = t3;
                                dmin = i;
                            }
                    break;

                    case 4: 
                            Console.WriteLine("Ingrese la temperatura del dia Jueves: ");
                            t4 = Convert.ToSingle(Console.ReadLine());
                            if (t4 > tmax)
                            {
                                tmax = t4;
                                dmax = i;
                            }

                            if (t4 < tmin)
                            {
                                tmin = t4;
                                dmin = i;
                            }          
                    break;

                    case 5: 
                            Console.WriteLine("Ingrese la temperatura del dia Viernes: ");
                            t5 = Convert.ToSingle(Console.ReadLine());
                            if (t5 > tmax )
                            {
                                tmax = t5;
                                dmax = i;
                            }

                            if (t5 < tmin)
                            {
                                tmin = t5;
                                dmin = i;
                            }          
                    break;

                    case 6: 
                            Console.WriteLine("Ingrese la temperatura del dia Sabado: ");
                            t6 = Convert.ToSingle(Console.ReadLine());
                            if (t6 > tmax)
                            {
                                tmax = t6;
                                dmax = i;
                            }

                            if (t6 < tmin)
                            {
                                tmin = t6;
                                dmin = i;
                            }          
                    break;

                    case 7: 
                            Console.WriteLine("Ingrese la temperatura del dia Domingo: ");
                            t7 = Convert.ToSingle(Console.ReadLine());
                            if (t7 > tmax)
                            {
                                tmax = t7;
                                dmax = i;
                            }

                            if (t7 < tmin)
                            {
                                tmin = t7;
                                dmin = i;
                            }          
                    break;
                }
            }
            Console.Clear();
            Console.WriteLine("Su dia de la semana con mas temperatura es el {0} Con: {1} de temperatura\n\n", dmax, tmax);

            Console.WriteLine("Su dia de la semana con menos temperatura es el {0} Con: {1} de temperatura", dmin, tmin);
            Console.ReadKey();



            
        }
    }
}
