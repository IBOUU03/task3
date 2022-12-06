int number;
do
{
    Console.WriteLine("Qiyməti qeyd edin");
    number = Convert.ToInt32(Console.ReadLine());
    
} while (number < 0 || number > 100);

if (number <= 100 && number > 90)
{
    Console.WriteLine("A");
}
else if (number <= 90 && number > 80)
{
    Console.WriteLine("B");
}
else if (number <= 80 && number > 70)
{
    Console.WriteLine("C");
}
else if (number <= 70 && number > 60)
{
    Console.WriteLine("D");
}
else if (number <= 60 && number > 50)
{
    Console.WriteLine("E");
}
else
{
    Console.WriteLine("Kəsildiniz");
}
