using System;
using System.Security.Cryptography.X509Certificates;

namespace campus_intermediate_programming_I
{
    internal class Program
    {

        static void Main(string[] args)
        {

            // Ejercicio 1 - Operador ternario
            int randomNumber = new Random().Next(0, 1000);
            string greaterThan = $"{randomNumber} is greater than 500";
            string lessThan = $"{randomNumber} is less than 500";
            string result;

            result = randomNumber >= 500 ? greaterThan : lessThan;

            Console.WriteLine($"{result}\n");

            // Ejercicio 2 - Creación de excepciones y nullables
            try
            {
                int? nullNumber = null;
                string nullResult;

                nullResult = nullNumber == null ? throw new NullableException() : "nullNumber tiene valor";
                Console.WriteLine($"{nullResult}\n");

            }
            catch (NullableException nullableException)
            {
                Console.WriteLine($"{nullableException.Message}\n");
            }

            // Ejercicio 3 - Tipos anónimos y dinámicos
            var person = new { Name = "Aram", Age = 26 };
            Console.WriteLine($"{person.Name} {person.Age}\n");

            dynamic dynamicVariable = 7;
            Console.WriteLine(dynamicVariable);

            dynamicVariable = "Ahora soy un string ;D";
            Console.WriteLine(dynamicVariable);

            dynamicVariable = new { Number = 1, Message = "Soy texto", Money = 25.99 };
            Console.WriteLine($"{dynamicVariable.Number} {dynamicVariable.Message} {dynamicVariable.Money}\n");

            // Ejercicio 4 - Generics
            Random rng = new Random();
            var map = new Map<Pair>();
            for (int i = 0; i < 100; i++)
                if (i % 2 == 0)
                {
                    map.Put(i, new Pair.AddPair($"pairNumber:{i}", i * 5));
                }
                else
                {
                    map.Put(i, new Pair.AddPair($"impatirNumber:{rng.Next(50)}", $"El número {i} es impar"));
                }

            try
            {
                var pair1 = map.Get("Halo Infinite").Value;
                var pair2 = map.Get("Halo 4").Value;
                Console.WriteLine($"{pair1.Key}, {pair1.Value}\n");
                Console.WriteLine($"{pair2.Key}, {pair2.Value}\n");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"{map.GetAt(0)}.Key");

            // Ejercicio 5 - Extensión de métodos
            Console.WriteLine($"Primer valor del map {map.GetFirst().Key}: {map.GetFirst().Value}\n");

            // Ejercicio 6 - Regex
            string str = "Halo1234";
            Console.WriteLine($"El string {str} cumple con el patrón requerido: '1 letra mayúscula, seguido de tres letras minúsculas y 4 dígitos':  {str.RegexMatch()}");


            Console.ReadKey();
        }

    }
}
