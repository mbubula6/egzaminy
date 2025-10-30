using System;
class Program
{
    static void Main(string[] args)
    {
        Pralka pralka = new Pralka();
        Odkurzacz odkurzacz = new Odkurzacz();
        
        pralka.ustawNumerProgramuPrania(5); //poprawna wartość
        pralka.ustawNumerProgramuPrania(98); //niepoprawna wartość

        odkurzacz.on();
        odkurzacz.on();
        odkurzacz.on();
        odkurzacz.Komunikat("Odkurzacz wyładował się");
        odkurzacz.off();
    }
}
class Urzadzenie
{
/*
  *****************************************************************************
  nazwa:                Komunikat
  opis:                 Metoda wypisuje w konsoli podany komunikat.
  parametry:            komunikat (string) - zawiera komunikat do wyświetlenia
  zwracany typ i opis:  brak
  autor:                ja
  *****************************************************************************
*/
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
            Komunikat("Program został ustwiony");
        } else
        {
            numerProgramuPrania = 0;
            Komunikat("Podano niepoprawny numer programu");
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
