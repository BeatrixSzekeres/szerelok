using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication13
{
    public  class Burkolo : Mesterember
    {
        private string szakterulet;
        private BurkoloSzakteruletTipus belso;

        

        public Burkolo(string Nev, int Napidij, BurkoloSzakteruletTipus belso) : base(Nev, Napidij)
        {
            this.belso = belso;
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

        public int OsszesSzabadnap()
        {
            int szamlalo = 0;
            foreach (bool b in Foglaltnapok)
                if (b)
                    szamlalo++;
            return szamlalo;
        }

        public override string MindenAdat()
        {
            StringBuilder sb = new StringBuilder(base.MindenAdat());
            sb.AppendFormat("Szakterulet:{0}", Szakterulet.ToString());
            return sb.ToString();
           
        }

        public override bool  MunkatVallal(int Nap)
        {
            if(Foglaltnapok[Nap] == true)
            {
                Foglaltnapok[Nap] = false;
                return true;
            }
            return false;
        }
    }
}