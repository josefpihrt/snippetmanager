using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pihrtsoft.Snippets;

namespace SnippetManagerTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var xx = SnippetSerializer.DeserializeFile("test.snippet");

            var x = new Snippet();

            x.Literals.Add(Literal.CreateClassNameLiteral("test", "t", "d"));

            x.Save("test.snippet");

            Console.ReadKey();
        }
    }
}
