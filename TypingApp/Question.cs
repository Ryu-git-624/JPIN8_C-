using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingApp
{
    internal class Question
    {
        private string value;

        public Question(string value)
        {
            this.value = value;
        }

        public bool isMatch(string input)
        {
            return input.Equals(this.value);
        }

       public string getValue()
        {
            return this.value;
        }
    }
}
