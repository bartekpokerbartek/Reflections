using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            var attributes = person.GetType().GetCustomAttributes(false);
            //var descriptionAttribute = (DescriptionAttribute) Attribute.GetCustomAttribute(typeof(Person), typeof(DescriptionAttribute));

            foreach (var attribute in attributes)
            {
                if (attribute is DescriptionAttribute)
                {
                    var desc = (DescriptionAttribute) attribute;
                    Console.WriteLine(desc.Text);
                }
            }
        }
    }
}
