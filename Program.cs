using System;

namespace HashCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMapNode < string, string> hash = new MyMapNode<string, string>(5);
            hash.InsertItem("0", "To");
            hash.InsertItem("1", "be");
            hash.InsertItem("2", "or");
            hash.InsertItem("3", "not");
            hash.InsertItem("4", "to");
            hash.InsertItem("5", "be");

            string hash5 = hash.GetItem("5");
            Console.WriteLine("5th Index value is: " + hash5);
            hash.RemoveItem("2");
            //string hash2 = hash.GetItem("2");
            Console.WriteLine("Item removed at position 2");
            //Console.WriteLine(hash.ToString());
        }
    }
}
