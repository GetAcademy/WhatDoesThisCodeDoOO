using System;
using System.Reflection.PortableExecutable;

namespace WhatDoesThisCodeDoOO
{
    public class CharacterCounter
    {
        private static CharacterCounter _theInstance;

        private readonly int[] _counts;
        private const int Range = 250;

        private CharacterCounter()
        {
            _counts = new int[Range];
        }

        public static CharacterCounter Instance
        {
            get
            {
                if (_theInstance == null) // første gang
                {
                    _theInstance = new CharacterCounter();
                }
                return _theInstance;
            }
        }

        public void Show()
        {
            Console.WriteLine(CreateDescription());
        }

        public string CreateDescription()
        {
            var description = "";
            for (var i = 0; i < Range; i++)
            {
                if (_counts[i] == 0) continue;
                var character = (char)i;
                description += character + " - " + _counts[i] + "\n";
            }
            return description;
        }

        public void Count(string text)
        {
            foreach (var character in text ?? string.Empty)
            {
                _counts[(int)character]++;
            }
        }
    }
}
