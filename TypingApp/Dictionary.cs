using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TypingApp
{
    internal class Dictionary
    {
        private List<string> words = new List<string>();
        private int index = 0;

        public Dictionary()
        {
            words.Add("int");
            words.Add("long");
            words.Add("short");
            words.Add("byte");
            words.Add("bool");
            words.Add("float");
            words.Add("double");
            words.Add("char");
        }

        public string get()
        {
            string word = words[index];
            index++;
            return word;
        }

        public string getRandom()
        {
            index = new Random().Next(0,words.Count);
            string word = words[index];
            Console.WriteLine(index);
            return word;
        }
    }
}
