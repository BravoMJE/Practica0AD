// ************************************************************************
// Practica 00
// Tu Nombre va aqui
// Fecha de realizacion: 23/04/2016
// Fecha de entrega: xx/04/2016
// Resultados:
//* El codigo permita generar una tabla con potencias y una tabla con angulos y
//sus valores de las funciones seno y coseno
// Conclusiones:
//*
// Recomendaciones:
//*
// ************************************************************************

using System;

namespace Parte01

{

    class Program

    {

        /// <summary>

        /// Metodo que permite generar una tabla con las potencias de un numero

        /// </summary>

        /// <param name="desde"> Numero inicial para el calculo </param>

        /// <param name="hasta"> Numero final para el calculo </param>

        static void mostrarPotencias(int desde, int hasta)

        {

            // Cabecera de la tabla

            Console.WriteLine("x << xˆ2 << xˆ3");

            // Realizacion de calculos para obtencion de ponencias y presentacion

            // de resultados

            for (int x = desde; x <= hasta; x = x + 1)

            {

                Console.WriteLine("{0} << {1} << {2}", x, x * x, x * x * x);

            }

        }

        /// <summary>

        /// Metodo que permite generar una tabla con un conjunto de angulos y

        /// sus valores sin y cos

        /// </summary>

        /// <param name="desde"> Angulo inicial para el calculo </param>

        /// <param name="hasta"> Angulo final para el calculo </param>

        static void mostrarAngulos(int desde, int hasta)

        {

            const double PI = 3.141592653589793;

            // Cabecera de la tabla

            Console.WriteLine("grados << radianes << seno << coseno");

            // Calculos para obtencio de angulo en radianes, y sus valores de sin

            // y cos

            for (double x = desde; x <= hasta; x = x + 5.0)

            {

                double radianes;

                radianes = x * PI / 180.0;

                Console.WriteLine(x + " << " + radianes + " << " +

                Math.Sin(radianes) + " << " + Math.Cos(radianes));

            }

        }

        /// <summary>

        /// Metodo principal

        /// </summary>

        static int Main(string[] args)
        {

            // Presenta una tabla de potencias de los enteros comprendidos entre

            // 5 y 10

            mostrarPotencias(5, 10);

            Console.WriteLine();

            // Presenta una tabla con los angulos comprendidos entre 0 y 180

            // grados

            mostrarAngulos(0, 180);

            Console.WriteLine("Presione ENTER para terminar");

            Console.ReadLine();

            return 0;

        }

    }

}
