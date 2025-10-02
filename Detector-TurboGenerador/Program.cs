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
            Console.WriteLine("Detector de incendio y homa del Turbo Generador");
            
            Random n = new Random();

            while (true)
            {
                int temp = n.Next(70, 960);
                Console.WriteLine("La temperatura del Turbo Generador es: " + temp + "°C");
                if (temp < 190)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("La temperatura es normal...\n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("                       _____________                       ");
                    Console.WriteLine("                      /             \\                      ");
                    Console.WriteLine("                     /   TURBINA     \\                     ");
                    Console.WriteLine("       --------------                 --------------       ");
                    Console.WriteLine("=======|  ()   ()   ()   ()   ()   ()   ()   ()    |=======");
                    Console.WriteLine("       |-------------------------------------------|       ");
                    Console.WriteLine("       |                                           |       ");
                    Console.WriteLine("       |              GENERADOR ELECTRICO          |       ");
                    Console.WriteLine("=======|  [::::::: ROTOR :::::::]  [::::::::]      |       ");
                    Console.WriteLine("       |                                           |       ");
                    Console.WriteLine("       |                                           |       ");
                    Console.WriteLine("       ---------------------------------------------       ");
                    Console.WriteLine("                   \\_________________/                     ");
                    Console.ResetColor();
                }
                else if (temp >= 190 && temp < 210)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("¡Alerta! ¡Temperatura alta en el Turbo Generador!\n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("                       _____________                       ");
                    Console.WriteLine("                      /             \\                      ");
                    Console.WriteLine("                     /   TURBINA     \\                     ");
                    Console.WriteLine("       --------------                 --------------       ");
                    Console.WriteLine("=======|  ()   ()   ()   ()   ()   ()   ()   ()    |=======");
                    Console.WriteLine("       |-------------------------------------------|       ");
                    Console.WriteLine("       |                                           |       ");
                    Console.WriteLine("       |              GENERADOR ELECTRICO          |       ");
                    Console.WriteLine("=======|  [::::::: ROTOR :::::::]  [::::::::]      |       ");
                    Console.WriteLine("       |                                           |       ");
                    Console.WriteLine("       |                                           |       ");
                    Console.WriteLine("       ---------------------------------------------       ");
                    Console.WriteLine("                   \\_________________/                     ");
                    Console.ResetColor();
                }
                else if (temp >= 210 && temp < 300)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("¡Alerta! ¡Humo dectado en el Turbo Generador.....!\n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("                       _____________                       ");
                    Console.WriteLine("                      /             \\                      ");
                    Console.WriteLine("                     /   TURBINA     \\                     ");
                    Console.WriteLine("       --------------                 --------------       ");
                    Console.WriteLine("=======|  ()   ()   ()   ()   ()   ()   ()   ()    |=======");
                    Console.WriteLine("       |-------------------------------------------|       ");
                    Console.WriteLine("       |                                           |       ");
                    Console.WriteLine("       |              GENERADOR ELECTRICO          |       ");
                    Console.WriteLine("=======|  [::::::: ROTOR :::::::]  [::::::::]      |       ");
                    Console.WriteLine("       |                                           |       ");
                    Console.WriteLine("       |                                           |       ");
                    Console.WriteLine("       ---------------------------------------------       ");
                    Console.WriteLine("                   \\_________________/                     ");
                    Console.ResetColor();
                    Console.Beep(1000, 1000);
                }
                else if (temp >= 300)
                {
                    Console.ForegroundColor = ConsoleColor.Red; 
                    Console.WriteLine("¡Alerta! ¡Incendio detectado en el Turbo Generador!\n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("                       _____________                       ");
                    Console.WriteLine("                      /             \\                      ");
                    Console.WriteLine("                     /   TURBINA     \\                     ");
                    Console.WriteLine("       --------------                 --------------       ");
                    Console.WriteLine("=======|  ()   ()   ()   ()   ()   ()   ()   ()    |=======");
                    Console.WriteLine("       |-------------------------------------------|       ");
                    Console.WriteLine("       |                                           |       ");
                    Console.WriteLine("       |              GENERADOR ELECTRICO          |       ");
                    Console.WriteLine("=======|  [::::::: ROTOR :::::::]  [::::::::]      |       ");
                    Console.WriteLine("       |                                           |       ");
                    Console.WriteLine("       |                                           |       ");
                    Console.WriteLine("       ---------------------------------------------       ");
                    Console.WriteLine("                   \\_________________/                     ");
                    Console.ResetColor();
                    Console.Beep(1500, 5300);
                }
                // Si el usuario presiona 'q', salir del bucle
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Q)
                {
                    break;
                }
                Thread.Sleep(2000); 
            }
        }
    }
}
