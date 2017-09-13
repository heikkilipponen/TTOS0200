using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Olio-ohjelmoinnin viikkotehtävät Labra 1
//Heikki Lipponen
namespace Labrat
{
    class Lab01
    {
        public static void tehtava1()
        // Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme).
        //Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku". 
        {
            int luku;
            Console.Write("anna luku 1 - 3 >");
            luku = int.Parse(Console.ReadLine());
            if (luku == 1)
            {
                Console.WriteLine("Annoit luvun yksi");
            }
            else if (luku == 2)
            {
                Console.WriteLine("Annoit luvun kaksi");
            }
            else if (luku == 3)
            {
                Console.WriteLine("Annoit luvun kolme");
            }
            else
            {
                Console.WriteLine("Joku muu luku");
            }
        }


        public static void tehtava2()
        //Tee ohjelma, jossa annetaan oppilaalle koulunumero seuraavan taulukon mukaan
        //(pistemäärä kysytään ja ohjelma tulostaa numeron): 
        {
            int luku;
            Console.Write("Anna pistemäärä > ");
            luku = int.Parse(Console.ReadLine());
            if (luku >= 0 && luku <= 1)
            {
                Console.WriteLine("Koulunumero on: 0");
            }
            else if (luku >= 2 && luku <= 3)
            {
                Console.WriteLine("Koulunumero on: 1");
            }
            else if (luku >= 4 && luku <= 5)
            {
                Console.WriteLine("Koulunumero on: 2");
            }
            else if (luku >= 6 && luku <= 7)
            {
                Console.WriteLine("Koulunumero on: 3");
            }
            else if (luku >= 8 && luku <= 9)
            {
                Console.WriteLine("Koulunumero on: 4");
            }
            else if (luku >= 10 && luku <= 12)
            {
                Console.WriteLine("Koulunumero on: 5");
            }
        }


        public static void tehtava3()
        //Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon. 
        {
            int luku1;
            int luku2;
            int luku3;

            Console.Write("Anna luku > ");
            luku1 = int.Parse(Console.ReadLine());

            Console.Write("Anna luku > ");
            luku2 = int.Parse(Console.ReadLine());

            Console.Write("Anna luku > ");
            luku3 = int.Parse(Console.ReadLine());

            double summa = luku1 + luku2 + luku3;
            Console.WriteLine("Lukujen summa: " + summa);

            double keskiarvo = summa / 3;
            Console.WriteLine("Lukujen keskiarvo: " + keskiarvo);
            
        }
        public static void tehtava4()
        // Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. Jos ikä on alle 18 vuotta, tulosta "alaikäinen",
        //jos se on 18-65 vuotta, tulosta "aikuinen", muussa tapauksessa tulosta "seniori".
        {
            int ika;
            Console.WriteLine("Syötä ikäsi");
            ika = int.Parse(Console.ReadLine());
            if (ika < 18)
            {
                Console.WriteLine("Alaikäinen");
            }
            else if (ika >= 18 && ika <= 65)
            {
                Console.WriteLine("Aikuinen");
            }
            else
            {
                Console.WriteLine("Seniori");
            }
        }


        public static void tehtava5()
        //Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina.
        //Aikamääre sekuntteina kysytään käyttäjältä. 
        {
            int luku;
            int tunnit;
            int minuutit;
            int sekunnit;

            Console.WriteLine("Anna sekunnit >");
            luku = int.Parse(Console.ReadLine());

            tunnit = luku / 3600;
            minuutit = (luku % 3600) / 60;
            sekunnit = ((luku % 3600) % 60);

            Console.WriteLine("Antamasi sekunttiaika voidaan ilmaista muodossa: " + tunnit + (" tuntia ") + minuutit + (" minuuttia ") + sekunnit + (" sekuntia "));
        }


        public static void tehtava6()
        //Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa.
        //Tee ohjelma, joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän.
        {
            double matka;
            double kulutus = 7.02;
            double kokonaiskulutus;
            double hinta = 1.595;
            double kustannus; 

            Console.WriteLine("Anna matka >");
            matka = double.Parse(Console.ReadLine());
            kokonaiskulutus = (matka / 100) * kulutus;
            kustannus = kokonaiskulutus * hinta;

            Console.WriteLine("Bensaa kuluu " + kokonaiskulutus + (" litraa, kustannus ") + kustannus + (" euroa"));
        }

        public static void tehtava7()
        //Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä. 
        {
            
            int vuosi;

            Console.WriteLine("Anna vuosi >");
            vuosi = int.Parse(Console.ReadLine());

            if (vuosi % 4 == 0 && vuosi % 100 != 0 || (vuosi % 400 == 0))
            {
                Console.WriteLine("Vuosi on karkausvuosi");
            }
            else
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi");
            }
        }

        public static void tehtava8()
        //Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.
        {
            int luku;
            int luku2 = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Anna luku > ");
                luku = int.Parse(Console.ReadLine());
                if (luku > luku2) luku2 = luku;
            }

            Console.WriteLine("Suurin luku on " + luku2);
        }
      

        public static void tehtava9()
        //Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0. Ohjelman tulee tulostaa syötettyjen lukujen summa. 
        {
            int luku;
            int summa = 0;

            do
            {
                Console.WriteLine("Anna luku: ");
                luku = int.Parse(Console.ReadLine());
                summa += luku;
            } while (luku != 0);

            Console.WriteLine("Lukujen summa on: " + summa);
        }


        public static void tehtava10()
        //Tee ohjelma, joka alustaa sovellukseen käyttöö seuraavan taulukon arvot = [1,2,33,44,55,68,77,96,100].
        //Käy sovelluksessa taulukko läpi ja tulosta ruutuun "HEP"-sana aina kun taulukossa oleva luku on parillinen. 
        {
            int[] numberArray = new int[] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };

            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] % 2 == 0)
                {
                    Console.WriteLine(numberArray[i] + ": HEP!");
                }
                else
                    Console.WriteLine(numberArray[i]);
            }
        }

        public static void tehtava11()
        /* Tee kahden sisäkkäisen for-silmukan avulla ohjelma, joka tulostaa seuraavanlaisen kuvion:
        *
        **
        ***
        ****
        *****
        Käyttäjä antaa syötteenä tähtirivien lukumäärän. Yllä olevassa esimerkissä käyttäjä on syöttänyt luvun 5.*/
        {
            int rivit;

            Console.WriteLine("Anna luku >");
            rivit = int.Parse(Console.ReadLine());

            rivit = rivit + 1;
            for (int i = 0; i < rivit; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }


        public static void tehtava12()
        //Tee ohjelma, joka kysyy käyttäjältä 5 kokonaislukua. Luvut tulee sijoittaa taulukkoon.
        //Ohjelman tulee tulostaa annetut luvut käänteisessä järjestyksessä.
        {
            int[] luvut = new int[5];
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Anna luku >");
                luvut[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Luvut ovat ");
            for (int i = 4; i >= 0; i--)
            {
                Console.Write(luvut[i] + ", ");
            }
        }
    }
}
