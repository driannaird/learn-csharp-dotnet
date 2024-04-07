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
        }
    }
}