namespace keywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A anyname = new A(5);
            anyname.getDoubleNumberOfWheels();
            Console.WriteLine(A.someNumber);
            A anyvalue = new A(6);
            anyvalue.getDoubleNumberOfWheels();
            Console.WriteLine(A.someNumber);
            anyname.getDoubleNumberOfWheels();
            Console.WriteLine(A.someNumber);//class static variables dont matter where it access of objects it can be changed
            
        }
    }
}