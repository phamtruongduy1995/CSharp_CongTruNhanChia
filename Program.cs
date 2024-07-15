internal class Program
{
    /// <summary>
    /// Hàm tính tông
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Cộng trừ hai số");
        int so1, so2, tong, hieu, tich, thuong;
        Console.WriteLine("Nhập Số 1: ");
        so1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập Số 2: ");
        so2 = Convert.ToInt32(Console.ReadLine());

        tong = so1 + so2;
        hieu = so1 - so2;
        tich = so1 * so2;

        Console.WriteLine($"tổng của 2 số là : {tong}");

        Console.WriteLine($"hieu của 2 số là : {hieu}");

        Console.WriteLine($"tich của 2 số là : {tich}");


        try
        {
            thuong = so1 / so2;
            Console.WriteLine($"thuong của 2 số là : {thuong}");

        }
        catch
        {

            Console.WriteLine($"không thể chia cho số 0!");
        }

    }
}