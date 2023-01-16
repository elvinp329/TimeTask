namespace TasksTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var defferenceTime = new DefferenceTime();
            Console.Write("Baslama vaxtini qeyd edin:");
            string time1 = Console.ReadLine();
            Console.Write("Bitme vaxtini qeyd edin:");
            string time2 = Console.ReadLine();
            string time3;
            var result = defferenceTime.Defference(time1, time2, out time3);
            Console.WriteLine(result.ToString());





            Console.WriteLine("Hello, World!");
        }
    }
}