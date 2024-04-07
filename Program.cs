using System;
namespace LearningCsharp{
    class Animal{
        static void Main(string[] args){
            // Console.WriteLine("Animal List");
            // Console.WriteLine("----------------");
            // Console.WriteLine("1. Elephant");
            // Console.WriteLine("2. Spider");

            // string nama = "Drian";
            // int umur = 19;
            // double nilaiAkademik = 3.54;

            // Console.WriteLine("Nama" + " " + nama);
            // Console.WriteLine(umur + " " + "tahun");
            // Console.WriteLine("IPK" + " " + nilaiAkademik);

            // Console.WriteLine(nama.Length);
            // Console.WriteLine(nama.ToUpper());
            // Console.WriteLine(nama.ToLower());
            // Console.WriteLine($"hai {nama} apa kabar?");

            // // Full text
            // string text = "John Doe";

            // // Location of the letter D
            // int charPos = text.IndexOf("h");

            // // Get last text
            // string lasttext = text.Substring(charPos);

            // // Print the result
            // Console.WriteLine(lasttext);

            // string namaInput = Console.ReadLine();
            // Console.WriteLine("Hallo " + namaInput);    

            // int myInt = 9;
            // double myDouble = myInt;

            // Console.WriteLine(myInt);
            // Console.WriteLine(myDouble);

            // Console.WriteLine(myInt.GetType());      // Outputs System.Int32
            // Console.WriteLine(myDouble.GetType());   // Outputs System.Double

            double myDouble = 9.78;
            int myInt = (int) myDouble;
            int myOtherInt = Convert.ToInt32(myDouble);

            Console.WriteLine(myDouble);
            Console.WriteLine(myInt);
            Console.WriteLine(myOtherInt); 

            Console.WriteLine(Math.E);
            Console.WriteLine(Math.PI);

            Console.WriteLine("===== Arithmetic Operator =====");
            int numberA;
            int numberB;
            int penjumlahan = 0, pengurangan = 0, perkalian = 0, modulus = 0;
            double pembagian = 0;

            Console.Write("Angka1 = ");
            numberA = int.Parse(Console.ReadLine());
            Console.Write("Angka2 = ");
            numberB = int.Parse(Console.ReadLine());

            penjumlahan = numberA + numberB;
            Console.WriteLine("{0} + {1} = {2}", numberA, numberB, penjumlahan);

            pengurangan = numberB - numberA;
            Console.WriteLine("{0} - {1} = {2}", numberA, numberB, pengurangan);

            perkalian = numberA * numberB;
            Console.WriteLine("{0} x {1} = {2}", numberA, numberB, perkalian);

            pembagian = numberA / numberB;
            Console.WriteLine("{0} / {1} = {2}", numberA, numberB, pembagian);

            modulus = numberA % numberB;
            Console.WriteLine("{0} % {1} = {2}", numberA, numberB, modulus);

            Console.WriteLine("===== Luas Persegi Panjang =====");
            int panjang = 5;
            int lebar = 4;

            int luas = panjang * lebar;
            Console.WriteLine("Luas = {0}", luas);

            Console.WriteLine("===== Assigment Operator =====");
            int angka1, angka2;
            angka1 = angka2 = 5;

            // angka1 = angka1 + angka2
            Console.WriteLine("Nilai angka1 += angka2 = {0}", angka1 += angka2);

            // angka1 = angka1 - angka2
            Console.WriteLine("Nilai angka1 -= angka2 = {0}", angka1 -= angka2);

            // angka1 = angka1 * angka2
            Console.WriteLine("Nilai angka1 *= angka2 = {0}", angka1 *= angka2);

            // angka1 = angka1 / angka2
            Console.WriteLine("Nilai angka1 /= angka2 = {0}", angka1 /= angka2);

            // angka1 = angka1 % angka2
            Console.WriteLine("Nilai angka1 %= angka2 = {0}", angka1 %= angka2);

            // angka1 = angka1 + 1 (increment)
            Console.WriteLine("Nilai angka1++ = {0}", angka1++);

            // angka1 = angka1 - 1 (decrement)
            Console.WriteLine("Nilai angka1-- = {0}", angka1--);
        }
    }
}