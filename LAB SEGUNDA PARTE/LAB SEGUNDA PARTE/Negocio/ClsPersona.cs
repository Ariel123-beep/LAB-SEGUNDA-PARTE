using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_SEGUNDA_PARTE.Negocio
{
    class ClsPersona
    {

            public ClsPersona(string nombre, int edad, string sexo, int peso, double altura)
            {
                calcularIMC(peso, altura);
                esMayorDeEdad(edad);
            }
            public static void calcularIMC(int peso, double altura)
            {
                double calcularPeso;

                calcularPeso = peso / (altura * altura);
                if (calcularPeso < 18)
                {
                    calcularPeso = -1;

                }
                if (calcularPeso >= 18 && calcularPeso <= 24.9)
                {
                    calcularPeso = 0;
                }

                if (calcularPeso == -1)
                {
                    Console.WriteLine("Tienes muy poco peso para tu estatura");
                }
                if (calcularPeso == 0)
                {
                    Console.WriteLine("Tienes peso normal para tu estatura");
                }
                else
                {
                    Console.WriteLine("Tienes mucho peso para tu estatura");
                }


            }
            public void esMayorDeEdad(int edad)
            {
                bool mayor;
                if (edad >= 18)
                {

                    mayor = true;
                }
                else
                {
                    mayor = false;
                }
                Console.WriteLine("Soy mayor?: " + mayor);
            }

            private void comprobarSexo(char sexo)
            {
                if (sexo != 'H' || sexo != 'M')
                {
                    sexo = 'H';
                }
                Console.WriteLine(sexo);
            }

            public void toString()
            {

            }

            private static void generaDNI()
            {
                int DNI;
                int resultadoA;
                int resultadoB;
                int resultado;
                string[] letras = new string[23] { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
                Random r = new Random();
                DNI = r.Next(99999999);
                resultadoA = DNI / 23;
                resultadoB = resultadoA * 23;
                resultado = DNI - resultadoB;
                Console.WriteLine(DNI + "-" + letras[resultado]);

            }
    



    }
}
