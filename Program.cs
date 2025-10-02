namespace BankManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            FormFlash ff = new FormFlash();
            ff.ShowDialog();
            if (ff.DialogResult == DialogResult.OK) { Application.Run(new FormMain()); }

            //Application.Run(new FormAddEdit(0));
        }
    }
}