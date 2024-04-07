# Tipe Casting

Type casting \*atau konversi suatu tipe data terjadi ketika kita menetapkan nilai dari satu tipe data ke tipe data lainnya. Jika tipe datanya kompatibel, maka C# melakukan konversi tipe otomatis yang dikenal sebagai konversi jenis implicit . Jika tidak sebanding, maka mereka perlu dikonversi secara eksplisit yang dikenal sebagai konversi jenis eksplisit. Misalnya, menetapkan nilai int ke tipe data long.

Implicit Casting (automatically) - mengubah tipe yang lebih kecil ke ukuran tipe yang lebih besar
char -> int -> long -> float -> double

Explicit Casting (manually) - mengubah tipe yang lebih besar ke tipe ukuran yang lebih kecil
double -> float -> long -> int -> char

## Implicit Type Casting / Automatic Type Conversion

Tipe data numerik kompatibel satu sama lain tetapi tidak ada konversi otomatis yang didukung dari tipe numerik ke char atau boolean. Seperti, char dan boolean tidak kompatibel satu sama lain.

```C#
    int myInt = 9;
    double myDouble = myInt;

    Console.WriteLine(myInt);
    Console.WriteLine(myDouble);

    Console.WriteLine(myInt.GetType());      // Outputs System.Int32
    Console.WriteLine(myDouble.GetType());   // Outputs System.Double
```

## Explicit Type Casting

Jika kita ingin mengkonversi nilai tipe data yang lebih besar ke tipe data yang lebih kecil, kita perlu melakukan konversi jenis eksplisit.

```C#
    double myDouble = 9.78;
    int myInt = (int) myDouble;    // Manual casting: double to int

    Console.WriteLine(myDouble);   // Outputs 9.78
    Console.WriteLine(myInt);      // Outputs 9

    Console.WriteLine(myDouble.GetType());   // Outputs System.Double
    Console.WriteLine(myInt.GetType());      // Outputs System.Int32
```

## Type Conversion Methods

Kita juga dapat mengkonversi tipe data secara eksplisit dengan menggunakan built-in methods, seperti Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) dan Convert.ToInt64 (long) :

```C#
    int myInt = 10;
    double myDouble = 5.25;
    bool myBool = true;

    Console.WriteLine(Convert.ToString(myInt));    // convert int to string
    Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
    Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
    Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
```
