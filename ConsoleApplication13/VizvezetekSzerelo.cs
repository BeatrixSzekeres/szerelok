using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication13
{
    public class VizvezetekSzerelo : Mesterember
    {
        public int nTapasztalat;
        

        public VizvezetekSzerelo(string Nev, int Napidij, int Tapasztalat) : base(Nev, Napidij)
        {
            nTapasztalat = Tapasztalat;
        }

        public int tapasztalat
        {
            get
            {
                return nTapasztalat;
            }

            set
            {
                if (value <= nTapasztalat)
                    throw new Exception("asd");
                nTapasztalat = value;
            }
        }

        public override string MindenAdat()
        {
            StringBuilder sb = new StringBuilder(base.MindenAdat());
            sb.AppendFormat("Tapasztalat:{0}", nTapasztalat.ToString());
            return sb.ToString();
        }

        public override bool MunkatVallal(int Nap)
        {
            if (Nap < 1 || Nap > 31)
                throw new Exception("nincsilyen");

            if (Foglaltnapok[Nap - 1] && Foglaltnapok[Nap] && Foglaltnapok[Nap + 1])
            {
                Foglaltnapok[Nap - 1] = false;
                Foglaltnapok[Nap] = false;
                Foglaltnapok[Nap + 1] = false;

                return false;
            }
            return true;
        }
    }
}