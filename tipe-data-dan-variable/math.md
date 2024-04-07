# Fungsi Math

Pada C#, fungsi - fungsi matematika terdapat pada class Math yang berada pada namespace System. Class Math digunakan untuk menyediakan fungsi - fungsi dan konstanta statis untuk logaritmik, trigonometri, dan fungsi matematika berguna lainnya.

## Example

```C#
using System;
namespace MathFunction{
    class ProgramMathFunction{
        static void main (string[] args){
            // Field
            // To find E constant values
            Console.WriteLine("Math.E = " + Math.E);
            // To find PI constant values
            Console.WriteLine("Math.PI = " + Math.PI);

            // Methods
            // Using FLoor() Method
            Console.WriteLine("Floor value of 123.123: " + Math.Floor(123.123));
            // Using Cos() Method
            Console.WriteLine("Cos value of 0.35: " + Math.Cos(0.34));
            // Using Sqrt() Method
            Console.WriteLine("Square Root of 81: " + Math.Sqrt(81));
            // Using Round() Method
            Console.WriteLine("Round value of 14.6534: " + Math.Round(14.6534));
        }
    }
}
```

Output
Math.E = 2.718281828459045
Math.PI = 3.141592653589793
Floor value of 123.123 = 123
Cos value of 0.35 = 0.9393727128473789
Square Root of 81 = 9
Round value of 14.6534 = 15

## Fields

E = Represents the natural logarithmic base, specified by the constant, e.
PI = Represents the ratio of the circumference of a circle to its diameter, specified by the constant, phi
Tau = Represents the number of radians in one turn, specified by the constant

## Methods

Abs() = Returns the absolute value of a speciefied number.
Acos() = Returns the angle whose cosine in the specified number.
Acosh() = Returns the Inverse hyperbolic cosine of the specified number.
Asin() = Returns the angle whose sine is the specified number.
Asinh() = Returns the Inverse hyperbolic sine of the specified number.
Atan() = Returns the angle whose tangent is the specified number.
Atan2() = Returns the angle whose tangent is the quotient of two specified numbers.
Atanh() = Returns the Inverse hyperbolic tangent of the specified number.
BigMul() = Produces the full product of two 32-bit numbers.
Cbrt() = Returns the cube root of a specified value.
Ceiling() = Returns the smallest integral value greater than or equal to the specified number.
Clamp() = It is used to restrict a value to a given range.
Cos() = Returns the cosine of the specified angle.
Cosh() = Returns the hyperbolic cosine of the specified angle.
DivRem() = Calculates the quotient of two numbers and also returns the remainder in an output parameter.
Exp() = Returns e raised to the specified power.
Floor() = Returns the largest integral value less than or equal to the specified number.
IEEERemainder() = Returns the remainder resulting from the division of a specified number by another specified number.
Log() = Returns the logarithm of a specified number.
Log10() = Returns the base 10 logarithm of a specified number.
Max() = Returns the larger of two specified numbers.
Min() = Returns the smaller of two numbers.
Pow() = Returns a specified number raised to the specified power.
Round() = Rounds a value to the nearest integer or to the specified number of fractional digits.
Sign() = Returns an integer that indicates the sign of a number.
Sin() = Returns the sine of the specified angle.
Sinh() = Returns the hyperbolic sine of the specified angle.
Sqrt() = Returns the square root of a specified number.
Tan() = Returns the tangent of the specified angle.
Tanh() = Returns the hyperbolic tangent of the specified angle.
Truncate() = Calculates the integral part of a number.

Dokumentasi lengkap tentang Math [here](https://learn.microsoft.com/en-us/dotnet/api/system.math?view=net-6.0)
