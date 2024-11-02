namespace kiemtracau2
{
    internal class Program
    {
        public delegate int Operation(int a, int b);

        // b) Phương thức Add thực hiện phép cộng
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static void Main(string[] args)
        {
            // c) Sử dụng delegate để tham chiếu đến phương thức Add
            Operation operation = Add;

            // d) Thực hiện delegate để tính tổng 5 và 10
            int result = operation(5, 10);

            Console.WriteLine("Tong 5 va 10 la: " + result);
        }
    }
}
