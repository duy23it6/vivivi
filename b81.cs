using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Sử dụng Thread.Sleep()
        Console.WriteLine("Bắt đầu sử dụng Thread.Sleep()");
        Thread.Sleep(2000); // Dừng luồng hiện tại trong 2 giây
        Console.WriteLine("Kết thúc sử dụng Thread.Sleep()");

        // Sử dụng Task.Delay()
        Console.WriteLine("Bắt đầu sử dụng Task.Delay()");
        Task.Delay(2000).Wait(); // Tạo một Task và chờ 2 giây
        Console.WriteLine("Kết thúc sử dụng Task.Delay()");
        /*Sự khác biệt giữa Thread.Sleep(100) và Task.Delay(100) là:

Thread.Sleep(100):
Thuộc về namespace System.Threading.
Dùng để đình chỉ thực thi của luồng hiện tại trong một khoảng thời gian nhất định (ở đây là 100 milliseconds).
Trong thời gian đình chỉ, luồng hiện tại sẽ không thể thực hiện bất kỳ hoạt động nào.
Việc sử dụng Thread.Sleep() có thể dẫn đến tình trạng "blocking" (chặn) của ứng dụng, làm giảm hiệu suất.
Task.Delay(100):
Thuộc về namespace System.Threading.Tasks.
Dùng để tạo ra một Task mới, đại diện cho một hoạt động không đồng bộ, và sẽ hoàn thành sau một khoảng thời gian nhất định (ở đây là 100 milliseconds).
Trong thời gian chờ đợi, luồng hiện tại vẫn có thể thực hiện các hoạt động khác.
Việc sử dụng Task.Delay() không dẫn đến tình trạng "blocking", do đó không ảnh hưởng đến hiệu suất của ứng dụng.*/
    }
}