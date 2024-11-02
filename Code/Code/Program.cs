namespace Code
{
    internal class Program
    {
        static void vd1()
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            int i = 0;
            while (i < N)
            {
                arr[i] = int.Parse(Console.ReadLine());
                i++;
            }
            for(int k = 0; k < N; k++)
            {
                Console.Write(arr[k] + " ");
            }

        }
        static void vd2()
        {
            int N = int.Parse(Console.ReadLine());
            while (N <= 0 || N >= 100)
            {
                N = int.Parse(Console.ReadLine());
            }
            int[] arr = new int[N];
            int i = 0;
            while (i < N)
            {
                arr[i] = int.Parse(Console.ReadLine());
                i++;
            }
            for (int k = 0; k < N; k++)
            {
                Console.Write(arr[k] + " ");
            }
            Console.WriteLine();
        }
        static void vd3()
        {
            Console.Write("Nhap so hang: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Nhap phan tu [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine($"Phan tu [{i},{j}]: " + matrix[i,j]);
                   // matrix[i, j] = int.Parse(Console.Write());
                }
            }
        }
        static void vd4()
        {
            Console.Write("Nhap so hang va so cot cua ma tran vuong: ");
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"Nhap phan tu [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.WriteLine($"Phan tu [{i},{j}]: "+ matrix[i, j]);
                    //matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void vd5()
        {
            Console.Write("Nhap mot xau ky tu: ");
            string input = Console.ReadLine();
            Console.WriteLine("Cac ky tu trong xau la:");
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }

        }

        static void vd6()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("Tong hai so la: " + sum);

        }

        static void vd7()
        {
            int N = int.Parse(Console.ReadLine());
            if (N % 2 == 0)
            {
                Console.WriteLine("N la so chan");
            }
            else
            {
                Console.WriteLine("N la so le");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //vd1();
            //vd2();
            //vd3();
            //vd4();
            //vd5();
            //vd6();
            vd7();
        }
    }
}
