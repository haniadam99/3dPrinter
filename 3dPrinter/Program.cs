using System; 

class program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int printers = 1;
        int days = 0;
        int statuesprinted = 0; 

        while (statuesprinted < n)
        {
            if ((n - statuesprinted) > printers)
            {
                days += 1;
                printers += printers;
                
            }
            else
            {
                days += 1;
                statuesprinted += printers;
            }
        }
        Console.WriteLine(days);
    }
}
