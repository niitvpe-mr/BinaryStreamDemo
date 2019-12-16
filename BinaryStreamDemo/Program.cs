using System;
using System.IO;

namespace BinaryStreamDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryWriter dataOut;
            BinaryReader dataIn;
            int i = 10;
            double d = 56.23;
            bool b = true;

            dataOut = new BinaryWriter(new FileStream("testData",FileMode.Create));
            Console.WriteLine("Writing "+i);
            dataOut.Write(i);

            Console.WriteLine("Writing "+d);
            dataOut.Write(d);

            Console.WriteLine("Writing " + b);
            dataOut.Write(b);

            Console.WriteLine("Writing "+12.2*8.3);
            dataOut.Write(12.2 * 8.3);

            dataOut.Close();
            Console.WriteLine();

            dataIn = new BinaryReader(new FileStream("testData",FileMode.Open));

            i = dataIn.ReadInt32();
            Console.WriteLine("Reading "+i);

            d = dataIn.ReadDouble();
            Console.WriteLine("Reading "+d);

            b = dataIn.ReadBoolean();
            Console.WriteLine("Reading "+b);

            d = dataIn.ReadDouble();
            Console.WriteLine("Reading " + d);

            Console.ReadLine();
            dataIn.Close();

        }
    }
}
