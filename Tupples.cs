namespace Tuples
{
    class Tuples
    {
        public static void Main()
        {
            (int, int) myTuple = (1, 2);
            var ageTuple = (Name: "Aidil", Age: 12);
            Console.WriteLine(ageTuple.Item1);
            Console.WriteLine(ageTuple.Age);
            
            
            // deconstruction
            var (name, age) = ("Kalunge ", 23);
            Console.WriteLine(name, age);
        }
    }
}