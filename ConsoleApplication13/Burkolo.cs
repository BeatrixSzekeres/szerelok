using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication13
{
    public abstract class Burkolo : Mesterember
    {
        private string szakterulet;

        public Burkolo(string Nev, string Napidij) : base(Nev, Napidij)
        {
        }

        public string Szakterulet
        {
            get
            {
                return szakterulet;
            }

            set
            {
                if (value != "Kulso" && value != "Belso")
                    throw new Exception("Nem jo a Szakterulet");
                else
                    szakterulet = value;
            }
        }

        public void OsszesSzabadnap()
        {
            throw new System.NotImplementedException();
        }

        public override string MindenAdat()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Nev);
            sb.AppendLine(Napidij);
            sb.AppendLine(szakterulet);
            return sb.ToString();
           
        }

        public bool  MunkatVallal()
        {
            for (int i = 0; i < 31; i++)
                if (Foglaltnapok[i] == true)
                    return true;
                else
                    return false;
            
        }
    }
}