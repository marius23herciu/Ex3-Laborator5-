using System;

namespace Ex3_Laborator5_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 3
            //Scrieti un program care va numara toate aparitiile unui caracter intr - un sir
            //de caractere.Atat caracterul cautat cat si sirul de caracter vor fi citite de la
            //tastatura

            Console.WriteLine("Introduceti un sir de caractere");
            string sir = Console.ReadLine();
            Console.WriteLine("Introduceti un caracter");
            char caracter = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int aparitiiCaracter = NumerotareCaracter(sir, caracter);
            Console.WriteLine($"Caracterul '{caracter}' a aparut de {aparitiiCaracter} ori in sirul introdus.", caracter, aparitiiCaracter);
        }
        static int NumerotareCaracter(string sir,char caracter)
        {
            int numerotare = 0;
            foreach (char simbol in sir)
            {
                if (simbol==caracter)
                {
                    numerotare++;
                }
            }
            return numerotare; 
        }
    }
}
