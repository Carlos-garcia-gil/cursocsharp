using System;
using System.Collections.Generic;

namespace gestionnotas
{
    class Program
    {
        static char EscapeCharacter = 'R';
        static string EscapeWord = "RUNYOUFOOLS";
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvendi@ al programa para gestión de alumnos");
            Console.WriteLine("Introduzca las notas de los alumnos");

            var notaDeAlumnos = new List<double>();
            var keepDoing = true;

            while (keepDoing)
            {
                Console.WriteLine($"Nota del alumno {notaDeAlumnos.Count + 1}");
                var notaText = Console.ReadLine();

                if (notaText == EscapeCharacter) 
                {
                    keepDoing = false;
                }
                else
                {
                    var nota = 0.0;

                    if (double.TryParse(notaText.Replace(".",","), out nota)) 
                    {
                        notaDeAlumnos.Add(nota);
                    }
                    else
                    {
                        Console.WriteLine("La nota intoducida es incorrecta melón!");
                    }
                }
            }

            var suma = 0.0;

            for (var i = 0; i < notaDeAlumnos.Count; i++)
            {
                suma += notaDeAlumnos[i];
            }

            var average = suma / notaDeAlumnos.Count;
            Console.WriteLine("La media los examenes es: {0}", average);
        }
    }
}
