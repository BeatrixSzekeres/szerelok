using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication13
{
    public abstract class Mesterember
    {
        private string Nev;
        private int Napidij;
       public bool[] Foglaltnapok = new bool [31];

        public Mesterember(string Nev, int Napidij)
        {
            throw new System.NotImplementedException();
        }

        public virtual string MindenAdat()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nev:{0} Napidij: {1}", Nev, Napidij);
            sb.AppendLine();

            

        }

        public abstract bool MunkatVallal(int Nap);
        
        }
    }
