using System;
using System.IO;

namespace Sentencias
{
    class SentenciasUs
    {
        public static void Main(string[] args)
        {
            string s;
            using (TextWriter w = File.CreateText("log.txt"))
            {
                w.WriteLine("linea 1");
                w.WriteLine("linea 2");
            }
            using (TextReader r = File.OpenText("log.txt"))
            {
                while ((s = r.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
