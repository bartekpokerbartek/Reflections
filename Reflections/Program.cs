using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(double);

            var intVar = 10;
            type = intVar.GetType();


            Console.WriteLine("Methods:");
            foreach (var methodInfo in type.GetMethods(BindingFlags.Public | BindingFlags.Instance))
            {
                Console.WriteLine(methodInfo.Name);
            }

            Console.WriteLine("Fields:");

            foreach (var fieldsInfo in type.GetFields())
            {
                Console.WriteLine(fieldsInfo.Name);
            }

            Console.WriteLine("Properties:");

            foreach (var propertyInfo in type.GetProperties())
            {
                Console.WriteLine(propertyInfo.Name);
            }

            //Assembly.
            //AssemblyName.

            //Console.ReadLine();

            //============================================================================================

            type = Type.GetType("Reflections.Person", false, true);
            type = typeof(Person);
            //type.

            MemberInfo[] Members = type.GetMembers();

            foreach (MemberInfo NextMember in Members)
            {
                Console.WriteLine(NextMember.DeclaringType + ", " + NextMember.MemberType + ", " + NextMember.Name);
            }

            var method = type.GetMethod("IsEmployed");

            var returnType = method.ReturnType;
            var parameters = method.GetParameters();

            //===========================================================================================
            var t = typeof(System.ComponentModel.DataAnnotations.Validator);
            string s = t.Assembly.FullName.ToString();

            var assembly = Assembly.Load(s);
            var attributes = Attribute.GetCustomAttributes(assembly);

            assembly = Assembly.GetExecutingAssembly();

            type = assembly.GetType("Reflections.Person");

            object obj = Activator.CreateInstance(type, new object[] { "Someone", 1000});

            method = type.GetMethod("IsEmployed");

            var result = method.Invoke(obj, null);
        }
    }
}
