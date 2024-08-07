using System.IO;

namespace _11_StreamReaderHexDump
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var position = 0;
            using (var reader = new StreamReader("textdata.txt"))
            {
                while (!reader.EndOfStream)
                {
                    // Прочитать следующие 16 байт из файла в массив байтов
                    var buffer = new char[16];
                    var bytesRead = reader.ReadBlock(buffer, 0, 16);
                    // Записать шестнадцатеричную позицию (или смещение), затем двоеточие и пробел
                    Console.Write("{0:x4}: ", position);
                    position += bytesRead;
                    // Записать шестнадцатеричное значение каждого символа в массив байтов
                    for (var i = 0; i < 16; i++)
                    {
                        if (i < bytesRead)
                            Console.Write("{0:x2} ", (byte)buffer[i]);
                        else
                            Console.Write(" ");
                        if (i == 7) Console.Write("-- ");
                    }
                    // Записать символы в массив байтов
                    var bufferContents = new string(buffer);
                    Console.WriteLine(" {0}", bufferContents.Substring(0, bytesRead));
                }
            }
        }
    }
}
