using System;

namespace FluentUri.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Fluent.Uri.Standard.Uri.Create("base", true)
                .AddSection("test")
                .AddParameter("p", "v")
                .AddFragment("frag")
                .AsString();
            Console.WriteLine(a);
        }
    }
}
