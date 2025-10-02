using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Detector_TurboGenerador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando el sistema de detección de incendio y humo del Turbo Generador...");
            Thread.Sleep(2000);
            Console.Clear();
            do
            {
                Console.WriteLine("Menú de opciones");
                Console.WriteLine("1. Turbo Generador");
                Console.WriteLine("3. Salir");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: TurboGenerador1(); break;
                    case 2:
                        Console.WriteLine("Saliendo del sistema...");
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            } while (true);
        }
        static void TurboGenerador1()
        {
            Random n = new Random();
            while (true)
            {
                int temp = n.Next(70, 460);
                Console.WriteLine("=====================================================");
                Console.WriteLine("La temperatura del Turbo Generador es: " + temp + "°C");
                Console.WriteLine("=====================================================");
                if (temp < 190)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("La temperatura es normal...\n");
                    Console.ResetColor();
                }
                else if (temp >= 190 && temp < 210)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("¡Alerta! ¡Temperatura alta en el Turbo Generador!\n");
                    Console.ResetColor();
                }
                else if (temp >= 210 && temp < 300)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("¡Alerta! ¡Humo dectado en el Turbo Generador.....!\n");
                    Console.ResetColor();
                    Console.Beep(1000, 1000);
                }
                else if (temp >= 300)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("¡Alerta! ¡Incendio detectado en el Turbo Generador!\n");
                    Console.ResetColor();
                    Console.Beep(1500, 5300);
                }
                Thread.Sleep(2000);
                Console.Clear();

                Console.WriteLine("=====================================================");
                Console.WriteLine("La temperatura del Turbo Generador es: " + temp + "°C");
                Console.WriteLine("=====================================================");
                if (temp < 190)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("La temperatura es normal...\n");
                    Console.ResetColor();
                }
                else if (temp >= 190 && temp < 210)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("¡Alerta! ¡Temperatura alta en el Turbo Generador!\n");
                    Console.ResetColor();
                }
                else if (temp >= 210 && temp < 300)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("¡Alerta! ¡Humo dectado en el Turbo Generador.....!\n");
                    Console.ResetColor();
                    Console.Beep(1000, 1000);
                }
                else if (temp >= 300)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("¡Alerta! ¡Incendio detectado en el Turbo Generador!\n");
                    Console.ResetColor();
                    Console.Beep(1500, 5300);
                }
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
    }
}
