using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication13
{
    public class Teszt
    {
        private Mesterember[] Mesteremberek = new Mesterember[6];

        public Teszt()
        {
            Mesteremberek[0] = new Burkolo("Tapeta Lajos", 60000, BurkoloSzakteruletTipus.belso);
            Mesteremberek[1] = new VizvezetekSzerelo("Megszer Elek", 12000, 3);
            Mesteremberek[2] = new Burkolo("Vakolat Peter", 50000, BurkoloSzakteruletTipus.kulso);
            Mesteremberek[3] = new VizvezetekSzerelo("Viz Elek", 15000, 5);
            Mesteremberek[4] = new Burkolo("Eresz Janos", 30000, BurkoloSzakteruletTipus.kulso);

        }
    }
}