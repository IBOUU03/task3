int number;
do
{
    Console.WriteLine("Ədəd daxil edin");
    number = Convert.ToInt32(Console.ReadLine());
} while (number <= 0);

if (number % 3 == 0 && number % 7 ==0)
{
    Console.WriteLine("Ədəd 7 və 3ə bölünür");
}
else
{
    Console.WriteLine("Ədəd 7 və 3ə bölünmür");
}