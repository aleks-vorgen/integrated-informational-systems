using System.Windows.Forms;

namespace lab1
{
    internal static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ExchangeRate());
        }
    }
}
