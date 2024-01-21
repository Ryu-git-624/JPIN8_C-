using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingApp
{
    internal class Examination
    {
        private List<Question> list = new List<Question>();

        public Examination(int size)
        {
            Dictionary dictionary = new Dictionary();
            for (int i = 0; i < size; i++)
            {
                list.Add(new Question(dictionary.get()));
                Console.WriteLine(list[i].getValue());
            }
        }

        public List<Question> getList()
        {
            return this.list;
        }
    }
}
