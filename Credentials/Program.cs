using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credentials
{
    public class SignIn
    {
        public string Username { get; set; }
        public string Password { get; set; }

        static string path = @"C:\Users\supra\OneDrive\Desktop\Credentials.txt";

        public static void WriteCredentials(SignIn sign)
        {
            BinaryWriter bin = new BinaryWriter(File.Open(path, FileMode.Create));
            bin.Write(sign.Username);
            bin.Write(sign.Password);
            bin.Close();
        }

        public static void ReadCredentials(SignIn sign)
        {
            BinaryReader brd = new BinaryReader(File.Open(path, FileMode.Open));
            sign.Username = brd.ReadString();
            sign.Password = brd.ReadString();
            brd.Close();

        }

        public class Test
        {
            static void Main(string[] args)
            {

                SignIn s = new SignIn();

                s.Username = "sramaraju";
                s.Password = "techie1";

                SignIn.WriteCredentials(s);
                SignIn.ReadCredentials(s);

                Console.WriteLine(s.Username + " " + s.Password);



            }

        }



    }
}
    

