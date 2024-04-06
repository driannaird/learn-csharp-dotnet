# Tipe Data

## Predefined Types (Tipe Data Bawaan)

byte 0 ~ 255

sbyte -128 ~ 127

short -32.768 ~ 32.767

ushort 0 ~ 65.535

int -2.147.483.648 ~ 2.147.483.647

uint 0 ~ 4.294.967.295

long -9.223.372.036.854.775.808 ~ 9.223.372.036.854.775.807

ulong 0 ~ 18.446.744.073.709.551.615

float -3.402823e38 ~ 3 .402823e38

double -1.79769313486232e308 ~ 1.79769313486232e308

decimal -79228162514264337593543950335 ~ -79228162514264337593543950335

char Sebuah karakter unicode

string Sebuah string karakter unicode

boolean True & Flase

object Sebuah Objek

## User-defined Types (Tipe data yang didefinisikan sendiri)

class, struct, interface, enum dan delegate.

# Deklarasi dan Inisialisasi Variabel

## Eksplisit dengan menuliskan tipe data lalu diikuti nama variabel.

```C#
    // mendeklarasikan variabel kosong
    string nama;
    int umur;
    float beratBadan;
    bool isMenikah;

    // inisialisasi variabel
    alamat = "Drian";
    umur = 19;
    beratBadan = 50.5;
    isMenikah = false;

    // deklarasi sekaligus inisialisasi variabel
    string nama = "Drian Key";
    int umur = 19;
    float nilaiAkademik = 3.54;
```

## Implisit tipe data tidak diketahui, maka membuat variabel dapat menggunakan kata kunci var.

```C#
    // deklarasi sekaligus inisialisasi variabel
    var nama = "Drian";
    var umur = 19;
    var nilaiAkademik = 3.54;
```

# Print variable

```C#
    Console.WriteLine(nama);
```

# Tipe Data String [Here](https://github.com/Drian-key/learn-csharp-dotnet/blob/main/tipe-data-&-variable/tipe-data-string.md)
