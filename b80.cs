using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Chạy hàm ff trong một luồng mới
        Thread thread = new Thread(FF);
        thread.Start();

        // Chờ luồng kết thúc
        thread.Join();

        // Hiển thị thông báo khi luồng kết thúc
        Console.WriteLine("Đã thực hiện xong.");
    }

    static void FF()
    {
        // Vòng lặp vô hạn
        while (true)
        {
            // Tạo số ngẫu nhiên
            int n = new Random().Next();

            // Kiểm tra nếu n chia hết cho 2025
            if (n % 2025 == 0)
            {
                // Dừng vòng lặp
                break;
            }

            // Hiển thị n
            Console.WriteLine(n);

            // Delay 100ms
            Thread.Sleep(100);
        }
    }
}