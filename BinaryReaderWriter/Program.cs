using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BinaryReaderWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteBinayData();
            Console.WriteLine("-----------------------------");
            ReadBinaryData();
            Console.WriteLine("-----------------------------");
            ReadBinaryData1();
            Console.WriteLine("-----------------------------");
        }

        static void WriteBinayData()
        {
            int a = 1;
            string b ="1234";
            byte[] arrData = { 0x01, 0x02, 0x03 };

            Stream stream = new FileStream("test.bin", FileMode.OpenOrCreate);
            using (BinaryWriter wr = new BinaryWriter(stream))
            {
                wr.Write(a);
                wr.Write(b);
                wr.Write(arrData);
            }
        }
        static void ReadBinaryData()
        {
            using (BinaryReader br = new BinaryReader(File.Open("test.bin", FileMode.Open)))
            {
                int a;
                string b;
                byte[] arrData = new byte[3];

                a = br.ReadInt32();
                b = br.ReadString();
                arrData = br.ReadBytes(3);

                Console.WriteLine("a:{0}", a);
                Console.WriteLine("b:{0}", b);
                for (int i = 0; i < arrData.Length; i++)
                {
                    Console.WriteLine("c:{0:x2}", arrData[i]);
                }

            }
        }

        static void ReadBinaryData1()
        {
            using (BinaryReader br = new BinaryReader(File.Open("test.bin", FileMode.Open)))
            {
                long dataLength = br.BaseStream.Length;
                byte[] readData = new byte[br.BaseStream.Length];
                readData = br.ReadBytes((int)br.BaseStream.Length);

                for (int i = 0; i < readData.Length; i++)
                {
                    Console.WriteLine("readData{0}:{1:x2}", i, readData[i]);
                }
            }
        }
    }
}
