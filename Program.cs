using System;
using System.IO;
using System.Linq;

namespace StringTxt
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] txtStrings;
            char space = ' ';
            string changeString;
            FileStream fileStream = new FileStream("E:\\Dersler\\C#\\StringTxt\\StringTxt\\complicatednew.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
            StreamReader reader = new StreamReader("E:\\Dersler\\C#\\StringTxt\\StringTxt\\complicated.txt");
            StreamWriter writer = new StreamWriter(fileStream);
            txtStrings = reader.ReadToEnd().Split(space);
            foreach (var txtString in txtStrings)
            {
                if (txtString.ToCharArray()[0]=='|' || txtString.ToCharArray()[0] == '/')
                {
                    changeString = txtString.Substring(1, txtString.Length-2);
                    Console.WriteLine(changeString);
                    writer.Write(changeString+" ");
                }
                else
                {
                    writer.Write(ReverseString(txtString)+" ");
                    
                }
                
            }
            writer.Close();
            Console.WriteLine("Kayıt Bitti");


        }
        public static string ReverseString(string srtVariable)
        {
            return new string(srtVariable.Reverse().ToArray());
        }
    }
}
