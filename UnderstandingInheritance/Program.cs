namespace UnderstandingInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio myradio = new Radio(false, "Pagaria");
            myradio.SwitchOn();
            myradio.ListenToTheRadio();
            myradio.SwitchOff();
            myradio.ListenToTheRadio();

            Console.WriteLine();

            TV myTV = new TV(false, "Pagaria");
            myTV.SwitchOn();
            myTV.WatchTheTV();
            myTV.SwitchOff();
            myTV.WatchTheTV();
        }
    }
}
