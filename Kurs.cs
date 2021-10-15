using System;
using System.Collections.Generic;
using System.Text;

namespace KlasserObjekt
{
    class Kurs
    {
        public string kursID;
        public string namn;
        public string startDatum;
        public string slutDatum;


        public Kurs(string akursID, string aNamn, string aStartDatum, string aSlutDatum)
        {
            kursID = akursID;
            namn = aNamn;
            startDatum = aStartDatum;
            slutDatum = aSlutDatum;

            Console.WriteLine($"Kursens ID är: {kursID}, kursens namn är {namn}, kursen startar: {startDatum}, kursen slutar: {slutDatum}.\n");
            Console.WriteLine("___________________________________________________________________________________________________________\n");
        }

    }
}
