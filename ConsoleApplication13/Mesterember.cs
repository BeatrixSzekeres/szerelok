using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication13
{
    public class Mesterember
    {
        public string Nev;
        public string Napidij;
       public bool[] Foglaltnapok = new bool [31];

        public Mesterember(string Nev, string Napidij)
        {
            throw new System.NotImplementedException();
        }

        public abstract string MindenAdat()
        {

            throw new System.NotImplementedException();

        }

        public bool  MunkatVallal(int Nap)
        {
            for (int i = 0; i < 31; i++)
                if (Foglaltnapok[i-1]  && Foglaltnapok[i+1] == true)
                    return true;
                else
                    return false;
        }
    }
}