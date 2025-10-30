using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("hi");
    }
}
class Urzadzenie
{
    public void Komunikat(string komunikat)
    {
        Console.WriteLine(komunikat);
    }
}
class Pralka : Urzadzenie
{
    private int numerProgramuPrania = 0;
    public int ustawNumerProgramuPrania(int danyNumerProgramuPrania)
    {
        if ( danyNumerProgramuPrania > 0 & danyNumerProgramuPrania < 12 )
        {
            numerProgramuPrania = danyNumerProgramuPrania;
        } else
        {
            numerProgramuPrania = 0;
        }
        return numerProgramuPrania;
    }

}
class Odkurzacz : Urzadzenie
{
    private bool stanOdkurzacza = false;
    public void on()
    {
        if (!stanOdkurzacza)
        {
            stanOdkurzacza = true;
            Komunikat("Odkurzacz włączono");
        }
    }
    public void off()
    {
        if (stanOdkurzacza)
        {
            stanOdkurzacza = false;
            Komunikat("Odkurzacz wyłączono");
        }
    }
}
