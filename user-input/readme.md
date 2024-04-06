# Memasukan Data Menggunakan Sintaks Input

## Mengambil User Input

Bisa menggunakan ReadLine() dan dapat mendeklarasikan disebuah variable

Fungsi Read() dan ReadKey() akan membaca satu huruf saja dari teks yang kita ketik. Read() akan menghasilkan tipe data int sedangkan ReadKey() akan menghasilkan data dengan tipe character.

```C#
    // Type your username and press enter
    Console.WriteLine("Enter username:");

    // Create a string variable and get user input from the keyboard and store it in the variable
    string userName = Console.ReadLine();

    // Print the value of the variable (userName), which will display the input valu e
    Console.WriteLine("Username is: " + userName);
```
