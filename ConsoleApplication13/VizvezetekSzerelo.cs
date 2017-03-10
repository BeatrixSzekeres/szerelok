using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication13
{
    public class VizvezetekSzerelo : Mesterember
    {
        public int Tapasztalat;
        

        public VizvezetekSzerelo(string Nev, string Napidij) : base(Nev, Napidij)
        {
        }

        public int tapasztalat
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public override string MindenAdat()
        {
            throw new System.NotImplementedException();
        }

        public void MunkatVallal(int HoNapSzam)
        {
            throw new System.NotImplementedException();
        }
    }
}