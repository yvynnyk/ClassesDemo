using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    class FamilyTree
    {
        public static void ShowFamily(Person parent)
        {
            ShowFamily(parent, 0);
        }
        private static void ShowFamily(Person parent, int counter)
        {
            var spaces = new string(' ', counter);
            Console.WriteLine(spaces + (parent.Child.Any() ? "*" : "-") + parent.FullName);
            foreach (var child in parent.Child)
            {
                ShowFamily(child, counter + 2);
            }
        }

    }
}
