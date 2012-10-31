using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using RFIDtoKeyboard;

namespace RFIDtoKeyboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Zargate RFID Keyboard Emulator";
            string comPort = "";
            CommunicationManager comm = new CommunicationManager(comPort);
            do
            {
                Console.WriteLine("Enter COM-port, e.g. COM4");
                comPort = Console.ReadLine();
                comm = new CommunicationManager(comPort);
            } while (!comm.OpenPort());
            while (true)
            {

            }

        }
    }
}
