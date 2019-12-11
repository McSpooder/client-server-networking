using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using WindowsFormsApp;
using NetworkingLibrary;

//This is the main console application of the location client

namespace location
{

    class Program
    {

        static void Main(string[] args)
        {
            //A windows form is launched when no arguments are sent into the program. 
            //Else it passes the arguments onto the client class and executes the server.
            if (args.Length == 0)
            {
                Console.WriteLine("Windows form launched.");
                MainForm f = new MainForm();
                Application.Run(f);
            }
            else
            {
                ClientClass.ExecuteClient(args);
            }
         
        }

    }

}
