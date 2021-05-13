namespace RRUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //IMenu menu = new MainMenu();
            //menu.Start();
            MenuFactory.GetMenu("main").Start();
        }
    }
}
