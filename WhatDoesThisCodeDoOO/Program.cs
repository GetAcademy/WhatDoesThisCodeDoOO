using System;

namespace WhatDoesThisCodeDoOO
{
    class Program
    {
        /*
         * private constructor
         * unit testing
         * lambda-uttrykk
         */
        static void Main(string[] args)
        {
            //var c = new CharacterCounter();
            var c = CharacterCounter.Instance;
         
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                c.Count(text);
                c.Show();
            }
        }

        
    }
}
