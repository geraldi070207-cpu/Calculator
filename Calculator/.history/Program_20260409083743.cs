// 25.61.0290 Geraldi

int a = 10, b = 11;

static int penjumlahan (int a, int b)
{
   return a + b;
}
static int pengurangan (int a, int b)
{
    return a - b;
}
static int perkalian (int a, int b)
{
    return a * b;
}
static int pembagian (int a, int b)
{
    return a / b;
}


Console.WriteLine(a," + ",b," = "+ penjumlahan(a,b));
Console.WriteLine(a," - ",b," = "+ pengurangan(a,b));
Console.WriteLine(a," * ",b," = "+ perkalian(a,b));
Console.WriteLine(a," / ",b," = "+ pembagian(a,b));