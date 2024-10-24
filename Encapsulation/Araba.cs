using System;

public class Araba
{
    public string Marka; // Araba markası
    public string Model; // Araba modeli
    public string Renk; // Araba rengi

    private int _kapıSayısı; // Özel alan

    // Kapı sayısı için property
    public int KapıSayısı
    {
        get { return _kapıSayısı; }
        set
        {
            if (value == 2 || value == 4)
            {
                _kapıSayısı = value; // Geçerli değer
            }
            else
            {
                Console.WriteLine("Hata: Kapı sayısı yalnızca 2 veya 4 olmalıdır.");
                _kapıSayısı = -1; // Geçersiz değer için -1 atanıyor
            }
        }
    }

    // Constructor
    public Araba(string marka, string model, string renk, int kapıSayısı)
    {
        Marka = marka;
        Model = model;
        Renk = renk;
        KapıSayısı = kapıSayısı; // Kapı sayısını ayarlarken kontrol yapılır
    }
}
