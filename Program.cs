using System;

namespace KlasserObjekt
{
    class Program
    {
        static void Main(string[] args)
        {
        Person Person1 = new Person("Axel", 18, 70, 2003);
        Person Person2 = new Person("Sven", 25, 83, 1996);
        Person Person3 = new Person("Roger", 44 , 100, 1977);
        Person Person4 = new Person("Karl", 19, 40, 2002);
        Person Person5 = new Person("Mohammed", 24, 75, 1997);
        Person Person6 = new Person("Elias", 17, 140, 2003);
        Person Person7 = new Person("Oliver", 20, 80, 2001);
        Person Person8 = new Person("Abdi", 24, 80, 1997);
        Person Person9 = new Person("Petter", 54, 85, 1967);
        Person Person10 = new Person("Benjamin", 17, 67, 2004);

        Kurs Kurs1 = new Kurs("ENGENG07", "Engelska 7", "2021-08-19", "2022-06-10");
        Kurs Kurs2 = new Kurs("MATMAT04", "Matematik 4", "2021-08-23", "2022-06-15");
        Kurs Kurs3 = new Kurs("SVESVE03", "Svenska 3", "2021-08-23", "2022-06-15");
        Kurs Kurs4 = new Kurs("KEMKEM01", "Kemi 1", "2021-08-23", "2022-06-15");
        Kurs Kurs5 = new Kurs("PRRPRR02", "Programmering 2", "2021-08-19", "2022-06-10");
        Kurs Kurs6 = new Kurs("WESWEB01", "Webbserverprogrammering 1", "2021-08-19", "2022-06-10");
        Kurs Kurs7 = new Kurs("WEUWEB02", "Webbutveckling 2", "2021-08-23", "2022-06-15");
        Kurs Kurs8 = new Kurs("GYARTE", "Gymnasiearbete", "2021-08-23", "2022-06-15");
        }

    }
}

