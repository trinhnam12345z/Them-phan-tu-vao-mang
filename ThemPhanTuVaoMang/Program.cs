using System;
using System.Text;

namespace ThemPhanTuVaoMang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr = { 7, 5, 9, 2, 1 };
            int x, k;
            Console.WriteLine("Nhập x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập vị trí cần chèn:");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mảng trước khi chèn: ");
            HienThi(arr, arr.Length - 1);
            Chen(arr, x, k);
            Console.WriteLine("Mảng sau khi chèn: ");
            HienThi(arr, arr.Length);
        }

        private static void Chen(int[] arr, int x, int k)
        {
            for (int i = arr.Length - 1; i > k; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[k] = x;
        }

        static void HienThi(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        
    }
}
