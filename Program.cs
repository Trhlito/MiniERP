namespace ERP3
{
    internal static class Program
    {
        /// Hlavn� vstupn� bod
        [STAThread]
        static void Main()
        {
            // Konfigurace aplikace
            ApplicationConfiguration.Initialize();

            // Spu�t�n� p�ihla�ovac�ho okna
            Application.Run(new LoginForm());
        }
    }
}