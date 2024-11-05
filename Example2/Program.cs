namespace Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Parking parking = new Parking("вул.Краснова", 10);
            Security sequrityMan = new Security("Микола");
            Police polishMan = new Police("Олександр");

            Parking.NotPlaces += sequrityMan.CloseParking;
            Parking.NotPlaces += polishMan.VideoSwitchOn;
            Parking.SignalTriggered += polishMan.DroveOutAddress;

            int i = 1;
            while (parking.TherePlaces)
            {
                Car c = new Car("Машина" + i);
                parking.PushCar(c);
                i++;
            }
        }
    }
}
