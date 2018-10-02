using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime date = null; //can't do this, causes compile error
            //Nullable<DateTime> date = null; //longhand way to type this
            DateTime? date = null;

            Console.WriteLine("GetValueOrDefault(): " + date.GetValueOrDefault());
            Console.WriteLine("HasValue: " + date.HasValue);
            Console.WriteLine("Value: " + date.Value);
        }
    }
}
