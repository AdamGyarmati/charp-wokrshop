using System;

namespace WorkShop // Note: actual namespace depends on the project name.
{
    internal class WorkShopDayOne
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello Again");

            //szám, szöveg/karakter, logikai

            //Primitívek
            //számok
            byte myByte = 1;
            short myShort = 2;
            int myInt = 3;
            long myLong = 400_000_000_000_000_000L;

            //lebegőpontos számok
            float myFloat = 1.1f;
            double myDouble = 2.2D;

            //karakter
            char myChar = 'a';

            //logikai
            bool myFirstBool = true;
            bool mySecondBool = false;

            //összetett adattípus
            String myName = "Ádám";
            String myString = "Itt egész mondatokat is tudok írni";

            //Operátorok:
            //Aritmetikai: +, -, *, /, %(modulo)
            int firstNumber = 10;
            int secondNumber = 3;
            int thirdNumber = firstNumber + secondNumber;
            Console.WriteLine(thirdNumber);

            //int sum = firstNumber + secondNumber;

            //1. feladat: Írjunk egy programot, ami létrehoz két egész szám típusú változót (‘a és b’)
            //és kiírja az
            //- összegüket
            //- különbségüket
            //- szorzatukat
            //- hányadosukat
            //- maradékos osztásuk eredményét.

            Console.WriteLine(firstNumber + secondNumber);
            Console.WriteLine(firstNumber - secondNumber);
            Console.WriteLine(firstNumber * secondNumber);
            Console.WriteLine(firstNumber / secondNumber);
            Console.WriteLine(firstNumber % secondNumber);


            //Assignment operátor =
            int a = 10;
            int b = 4;
            a = a + b;
            a += b;


            //Comparison operátor
            bool isTure = a > b;
            bool isEquals = 5 == 10; //csak primitíveknél használjuk
            bool notEquals = 5 != 10;
            bool isFalse = 7 <= 4;

            //Feltételvizsgálat
            //if (ide jön a feltétel) {
            //ha igaz a feltétel,
            //akkor fusson
            //le az itt
            //lévő kód
            //}

            bool isRaining = false;

            if (isRaining) //ha ez false akkor mi történjen
            {
                Console.WriteLine("Ma nem megyek sehova");
            }
            else //false esetén
            {
                Console.WriteLine("Irány focizni");
            }


            //Equals
            String myFavouriteColor = "red";
            Console.WriteLine(myFavouriteColor.Equals("Green"));

            if (myFavouriteColor.Equals("green"))
            {
                Console.WriteLine("Kedvenc színem a zöld");
            }
            else if (myFavouriteColor.Equals("orange"))
            {
                Console.WriteLine("Kedvenc színem a narancs");
            }
            else if (myFavouriteColor.Equals("yellow"))
            {
                Console.WriteLine("Kedvenc színem a sárga");
            }
            else
            {
                Console.WriteLine("Akkor nem tudom mi a kedvenc színed");
            }

            //logikai operátorok &&, ||, !

            //2. feladat: Vegyél fel egy int változót, és adj neki valami értéket!
            //Ha a változód értéke kisebb, mint 18, akkor írd ki, hogy
            //"te még nem ihatsz alkoholt".
            //Ha pont 18, akkor írd ki, hogy
            //"már pont ihatsz alkoholt"
            //Ha több, mint 18, akkor írd ki, hogy
            //"már ihatsz alkoholt"

            int age = 19;
            if (age < 18)
            {
                Console.WriteLine("Te még nem ihatsz alkoholt");
            }
            else if (age == 18)
            {
                Console.WriteLine("Már pont ihatsz alkoholt");
            }
            else
            {
                Console.WriteLine("Már ihatsz akoholt");
            }


            //Feladat közösen: Hozz létre egy számot, és ha a szám ösztható 2-vel és 20 alatt van,
            //akkor írd ki, hogy Fizz.
            //Ha nem osztható 2-vel és 20 fölött van akkor írd ki, hogy Buzz.
            //Ha éppen 20 vagy osztható 5-el akkor írd ki, hogy FizzBuzz

            int number = 30;

            if (number == 20 || number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 2 == 0 && number < 20)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 3 == 0 && number > 20)
            {
                Console.WriteLine("Buzz");
            }


            //ciklusok, loops
            //for (1. helyi változót létrehozok;
            //     2. bool -> addig fusson, amíg ez a feltétel igaz;
            //     3. i = i + 1 -> itt változtatom az értékét a helyi változómnak)
            //az i-t csak a cikluson belül érem el
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            //3. feladat: Írjuk ki a páros számokat 2-től 20ig
            for (int i = 2; i <= 20; i += 2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            //Stringek

            Console.WriteLine("Itt jönnek a stringek");

            String text = "Én egy szöveg vagyok.";
            String anotherText = "Én meg egy másik";

            //Konkatenálás
            String allTogether = text + anotherText;

            Console.WriteLine(allTogether);
            Console.WriteLine(allTogether.Length);
            Console.WriteLine(allTogether[0]);
            //a szöveg egy részletét lehet kiíratni
            //1. paraméter kezdő index (inclusive)
            //2. paraméter hogy a kezdő indextől számítva hány karaktert írjunk ki
            Console.WriteLine(allTogether.Substring(10));
            Console.WriteLine(allTogether.Substring(10, 5));

            //3. feladat: Vegyetek fel egy String változót,
            //aminek adjatok valami értéket és írjátok ki függőlegesen
            //egymás alá a karaktereit. pl:
            //String word = "bird";
            //output:
            //b
            //i
            //r
            //d
            String word = "bird";

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i]);
            }


            //4. feladat: Ugyan ezt a szöveget kiíratni így:
            //b
            //bi
            //bir
            //bird

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word.Substring(0, i + 1));
            }



            //dupla for ciklusos megoldás
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(word[j]);

                }
                Console.WriteLine();
            }

            // Vakáció visszafelé
            String vakáció = "Vakáció";

            for (int i = 0; i < vakáció.Length; i++)
            {
                int lastindex = vakáció.Length - 1;
                Console.WriteLine(vakáció.Substring(lastindex - i));
            }
        }
    }
}