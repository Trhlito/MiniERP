namespace ERP3
{
    internal static class Program
    {
        /// Hlavní vstupní bod
        [STAThread]
        static void Main()
        {
            // Konfigurace aplikace
            ApplicationConfiguration.Initialize();

            // Spuštìní pøihlašovacího okna
            Application.Run(new LoginForm());
        }
    }
}