using System;
using Gtk;

namespace BLPViewer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            MainWindow win = MainWindow.Create();
            win.Show();
            Application.Run();
        }
    }
}
