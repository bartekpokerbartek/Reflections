using Attributes;

//targets
[assembly: PersonClass]

namespace Attributes
{
    [type: PersonClass]
    [Description("Class description")]
    //[Description("Class description second")]
    class Person
    {
        [PersonClass]
        //[Description("Property description")]
        public int Age { get; set; }

        [return: PersonClass]
        public int GetAge([param: PersonClass] string parameter)
        {
            return Age;
        }
    }
}
