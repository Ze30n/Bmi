internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap chieu cao va can nang");
        double height = Convert.ToDouble(Console.ReadLine());
        double weight = Convert.ToDouble(Console.ReadLine());
        double bmi = weight / (Math.Pow(height,2));         //Pow   : mũ
        bmi = Math.Round(bmi, 1);                           //Round : làm tròn
        
        Console.WriteLine("Chi so BMI = " + bmi);

        if (bmi < 18)
                Console.WriteLine(" Thieu can ");
            else if (bmi < 25.0)
                Console.WriteLine(" Binh thuong ");
            else if (bmi < 30.0)
                Console.WriteLine(" Thua can ");
            else
                Console.WriteLine(" Beo phi ");
    }
}