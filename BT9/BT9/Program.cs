namespace BT9
{
    internal class Program
    {
        // [access modififier] delegate [return type] [delegate name] ([parameters])
        public delegate void FunctionPointer(int x, int y);
        public static void Add(int x, int y)
        {
            Console.WriteLine($"Add {x + y}");
        }
        public static void Subtract(int x, int y)
        {
            Console.WriteLine($"Subtract {x - y}");
        }
        public static void Multiply(int x, int y)
        {
            Console.WriteLine($"Multiply {x * y}");
        }
        public static void Divide(int x,int y)
        {
            Console.WriteLine($"Divide {x / y}");
        }
        public static void PerformCalculation(int x, int y, FunctionPointer ops)
        {
            ops(x,y);
            
        }
        static void Main(string[] args)
        {
            FunctionPointer pointer;
            pointer = Add;
            pointer += Subtract;
            pointer += Multiply;
            //pointer += Divide;
            /// funcs = [Add, Substract, Multiply, Divide]
            /// for item in funcs {item()}
            //Console.WriteLine(pointer(3,5));
            pointer(3, 5);
        }
    }
}
