using System;

namespace Lab1
{
    class VD5
    {
        static void Main5(string[] args)
        {
            string path = "C:\\Windowns\\MyFile.txt";
            bool found = true;
            if (found)
            {
                Console.WriteLine("Filepath: \'" + path + "\'");
            }
            else
            {
                Console.WriteLine("File Not Found! \a");
            }
        }
    }
}
