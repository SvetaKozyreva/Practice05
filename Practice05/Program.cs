namespace Practice05_V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int N = 5;
            Judge judge = new Judge(N);

            Sportsman.Event1 += judge.TargetOn;
            Sportsman.Event2 += judge.TargetOff;
            Judge.Event3 += judge.Success;
            Judge.Event4 += judge.Fail;

            for (int i = 1; i <= N; i++)
            {
                Sportsman sportsman = new Sportsman(i);
                sportsman.Vivod(); sportsman.Shoot();
            }

            judge.Count();
        }
    }
}
