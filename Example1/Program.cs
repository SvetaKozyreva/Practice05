namespace Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            TrafficLight svet = new TrafficLight();

            TrafficLight.Event1 += svet.Green;
            TrafficLight.Event2 += svet.Red;

            for (int i = 1; i <= 5; i++)
            {
                Pedestrian pesh = new Pedestrian("Пешехід" + i);
                Driver vod = new Driver("Водій" + i);

                TrafficLight.Event1 += pesh.Stand;
                TrafficLight.Event1 += vod.Ride;

                TrafficLight.Event2 += pesh.Go;
                TrafficLight.Event2 += vod.Stand;

                svet.ChangeLight(i);
            } 
        }
    }
}
