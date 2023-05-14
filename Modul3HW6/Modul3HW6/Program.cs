namespace Modul3HW6
{
    internal class Program
    {
        internal static void Main()
        {
            var messagebox = new MessageBox();
            messagebox.Open().GetAwaiter().GetResult();
        }
    }
}