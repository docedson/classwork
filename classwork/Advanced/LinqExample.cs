using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Advanced
{
    public class LinqExample
    {
        public void ShowMeLinq()
        {
            string[] names = { "Tom", "David", "Joan",
                "Sarah", "Mindy" };

            IEnumerable<string> query = names
                .Where(n => n.Contains("m") || n.Contains("d"))
                .OrderBy(n => n.Length)
                .Select(n => n.ToUpper());

            foreach (string name in query)
            {
                Console.WriteLine(name);
            }
        }
    }
}