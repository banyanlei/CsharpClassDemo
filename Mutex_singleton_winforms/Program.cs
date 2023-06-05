namespace Mutex_singleton_winforms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Mutex mutex = new Mutex(true, "{86BDF920-A643-460A-82A6-3611D16FD004}", out bool createNew);
            if (!createNew)
            {
                MessageBox.Show($"{Application.ProductName}已经在运行。", "提示");
                return;
            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}