using System.Diagnostics;

using Core;

namespace MapLoader_INIMaker // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reader.ReadFile();

            Process.GetCurrentProcess().WaitForExit();
        }
    }
}