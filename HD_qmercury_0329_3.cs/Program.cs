using System;

namespace HD_qmercury_0329_3.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            for (int i = 1; i < 11; i++) 
            {
                Console.WriteLine((2 * i) - 1);
                j = j + (2*i)-1;
            }
            Console.WriteLine($"Sum is {j}");
                    
        }
    }
}
// 1~20까지 수 중에서 홀수 값의 합을 출력하기