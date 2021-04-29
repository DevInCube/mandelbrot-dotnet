using System;
using System.Numerics;

for (double y = 1; y >= -1; y -= 0.05)
{
    for (double x = -2; x <= 0.5; x += 0.0315)
    {
        Console.Write(Complex.Abs(Mandelbrot(new Complex(x, y))) < 2 ? "*" : " ");
    }
    Console.WriteLine();
}

Complex Mandelbrot(Complex a)
{
    Complex z = 0;
    for (int i = 1; i <= 50; i++)
    {
        z = Complex.Pow(z, 2) + a;
    }
    return z;
}
