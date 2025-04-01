using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        //Bài 1:
        Console.WriteLine("Bài 1. Viết chương trình nhập vào tên và tuổi");
        Console.WriteLine("Nhập tên của bạn: ");
        string name = Console.ReadLine();
        Console.WriteLine("Nhập tuổi của bạn: ");
        string age = Console.ReadLine();
        Console.WriteLine($"Xin chào {name}, bạn {age} tuổi ");

        //Bài 2:
        Console.WriteLine("Bài 2. Viết chương trình tính diện tích của hình chữ nhật ");
        int x, y;
        Console.WriteLine("Nhập chiều dài");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập chiều rộng: ");
        y = int.Parse(Console.ReadLine());
        int z = x * y;
        Console.WriteLine($"Diện tích hình chữ nhật là {z}");

        //Bài 3:
        Console.WriteLine("Bài 3:  Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F");
        int F, C;
        Console.WriteLine("Nhập vào độ C: ");
        C = int.Parse(Console.ReadLine());
        F = (C * 9 / 5) + 32;
        Console.WriteLine($"Độ C sau khi chuyển qua độ F là: {F}");

        //Bài 4:
        Console.WriteLine("Bài 4. Viết chương trình kiểm tra số nguyên");
        int so_nguyen;
        Console.WriteLine("Nhập vào số nguyên: ");
        so_nguyen = int.Parse(Console.ReadLine());
        if (so_nguyen % 2 == 0)
        {
            Console.WriteLine("Là số chẵn");
        }
        else
        {
            Console.WriteLine("Không phải số chẵn");
        }

        //Bài 5: 
        Console.WriteLine("Bài 5. Viết chương trình tính tổng và tích của hai số nhập từ bàn phím");
        int so1, so2;
        Console.WriteLine("Ghi vào số thứ nhất: ");
        so1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ghi vào số thứ 2:");
        so2 = int.Parse(Console.ReadLine());
        int Sum = so1 + so2;
        Console.WriteLine($"Tổng của chương trình là: {Sum}");
        int product = so1 * so2;
        Console.WriteLine($"Tích của chương trình là: {product}");

        //Bài 6
        Console.WriteLine("Bài 6: Viết chương trình kiểm tra xem một số nhập vào có phải là số dương, số âm hay số không");
        int test;
        Console.WriteLine("Nhập vào một số: ");
        test = int.Parse(Console.ReadLine());
        if (test > 1)
        {
            Console.WriteLine("Là số dương");
        }
        else if (test < 0)
        {
            Console.WriteLine("Là số âm");
        }
        else
        {
            Console.WriteLine("Là số 0");
        }

        //Bài 7:
        Console.WriteLine("Bài 7: Viết chương trình kiểm tra một năm có phải là năm nhuận hay không");
        int year;
        Console.WriteLine("Nhập vào một năm: ");
        year = int.Parse(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        {
            Console.WriteLine($"{year} là năm nhuận");
        }
        else
        {
            Console.WriteLine($"{year} không phải là năm nhuận");
        }

        //Bài 8:
        Console.WriteLine("Bài 8: Viết chương trình in ra bảng cửu chương từ 1 đến 10.");
        int num, so_nhan;

        num = 1;

        do
        {

            so_nhan = 1;
            do
            {
                Console.WriteLine("{0} x {1} = {2}",
                    num, so_nhan, num * so_nhan);
                so_nhan++;
            }
            while (so_nhan <= 10);

            Console.WriteLine();
            num++;

        } while (num <= 10);

        //Bài 9:
        Console.WriteLine("Bài 9: Viết chương trình tính giai thừa của một số nguyên dương n");
        int n, giaithua = 1;
        Console.Write("Nhập vào số cần tính giai thừa: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            giaithua *= i;
        }
        Console.WriteLine($"{n}! = {giaithua}");

        //Bài 10:
        Console.WriteLine("Bài 10: Viết chương trình kiểm tra xem một số có phải là số nguyên tố hay không");
        int u, j, flag = 0; //flag dùng để đánh dấu
        Console.Write("Nhập vào một số: ");
        u = int.Parse(Console.ReadLine());
        for (j = 2; j <= u/2 ; j++)
        {
            if (u % j == 0)
            {
                Console.Write($"{u} không là số nguyên tố");
                flag = 1;
                break;
            }
        }
        if (flag == 0)
            Console.Write($"{u} là số nguyên tố");
    }
}
