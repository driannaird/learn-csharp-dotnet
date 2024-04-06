# Tipe Data String

Pada C# ketika kita mendefinisikan String dengan cara seperti berikut

```C#
    string sapaan = "Halo!";
```

## String Properti

Pada dasarnya string adalah sebuah object, dan terdapat sebuah properti dan method sehingga dapat melakukan operasi tertentu, contoh:

```C#
    string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    Console.WriteLine("The length of the txt string is: " + txt.Length);
    Console.WriteLine(txt.ToUpper());
    Console.WriteLine(txt.ToLower());
```

## String Method

Contoh method string yaitu ToUpper() dan ToLower()

```C#
    string txt = "Hello World";
    Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
    Console.WriteLine(txt.ToLower());   // Outputs "hello world"
```

## Concatenation

Operator + dapat digunakan untuk menggabungkan lebih dari satu string. Ini disebut concatenation.

```C#
    string firstName = "John ";
    string lastName = "Doe";
    string name = firstName + lastName;
    Console.WriteLine(name); // Output "John Doe"
```

Atau menggunakan method concat

```C#
    string firstName = "John ";
    string lastName = "Doe";
    string name = string.Concat(firstName, lastName);
    Console.WriteLine(name); // Output "John Doe"
```

## String Interpolation

Opsi lain dari Concatenation

```C#
    string firstName = "John";
    string lastName = "Doe";
    string name = $"My full name is: {firstName} {lastName}";
    Console.WriteLine(name);
```

## Access String

Mengakses string dengan menggunakan square brackets [] dan mengacu pada index angka di dalamnya

```C#
    string myString = "Hello";
    Console.WriteLine(myString[0]);  // Outputs "H"
```

Atau mengakses secara spesifik dengan IndexOf()

```C#
    string myString = "Hello";
    Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"
```

Substring(), berfungsi mengambil string baru dari index start yang ditentukan

```C#
    // Full name
    string name = "John Doe";

    // Location of the letter D
    int charPos = name.IndexOf("D");

    // Get last name
    string lastName = name.Substring(charPos);

    // Print the result
    Console.WriteLine(lastName);
```

## Spesial Karakter

\' ' Single quote

\" " Double quote

\\ \ Backslash

```C#
    // backslash ditambahkan pada double quote didalam sebuah string ( \" ):
    string txt = "We are the so-called \"Vikings\" from the north.";

    // backslash ditambahkan pada single quote didalam sebuah string (\') :
    string txt = "It\'s alright.";

    // backslash ditambahkan pada single backslash didalam sebuah string (\\):
    string txt = "The character \\ is called backslash.";
```

Escape character lainnya pada C# yang juga berguna adalah :

\n New Line
\t Tab
\b Backspace
