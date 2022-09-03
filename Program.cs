Console.Write("Введите число шариков которое вы бы хотели приобрести: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a==3 || a==5)
{
    Console.WriteLine("Да вы можете приобрести " +a + " шариков(а)");
}
else
{
    Console.WriteLine("К сожалению "+a +" шариков(а) приобрести нельзя");
}