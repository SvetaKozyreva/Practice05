namespace Example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            ManagingCompany mCo = new ManagingCompany();
            Lodger lodger = new Lodger("Ivanov", 900, 500);
            Meter checkPayments = new Meter();

            Meter.Event += checkPayments.SayCountDay;
            Meter.Event += mCo.ReportCheck;
            Meter.Event += lodger.Payment;

            for (int i = 1; i <= 30; i++)
            {
                checkPayments.CountDay(i);
            }
        }
    }
}
