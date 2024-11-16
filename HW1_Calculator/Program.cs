namespace HW1_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator Program");
            Console.WriteLine();
            Console.WriteLine("Lütfen bir sayı giriniz:");
            var number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen bir sayı daha giriniz");
            var number2 = Convert.ToDouble(Console.ReadLine());

            var toplam = number1 + number2;
            var fark = number1 - number2;
            var carpim = number1 * number2;
            var bolum = number1 / number2;

            Console.WriteLine("Sayıların toplamı: " + toplam);
            Console.WriteLine("Sayıların farkı: " + fark);
            Console.WriteLine("Sayıların çarpımı: " + carpim);
            Console.WriteLine("Sayıların bölümü: " + bolum);

        }
    }
}
