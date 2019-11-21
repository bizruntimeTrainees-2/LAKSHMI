using System;
using System.Threading;
using System.IO;
using System.Text;
namespace BinaryWriter1
{
    class Program
    {
        private static object textBox1;
        private static object test2Box;
        private static object test3Box;

        static void Main(string[] args)
        {
            FileStream fs = new FileStream("E://Lakky.txt",FileMode.OpenOrCreate);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(Convert.ToInt32(textBox1));
            bw.Write(Convert.ToInt32(test2Box));
            bw.Write(Convert.ToString(test3Box));

            fs.Flush();
            bw.Flush();
            fs.Close();
            bw.Close();
        }
    }
}
