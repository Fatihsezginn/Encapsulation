class Program
{
    static void Main(string[] args)
    {
        // Geçerli kapı sayısı
        Araba araba1 = new Araba("Toyota", "Corolla", "Kırmızı", 4);
        Console.WriteLine($"Araba 1: {araba1.Marka} {araba1.Model}, Renk: {araba1.Renk}, Kapı Sayısı: {araba1.KapıSayısı}");

        // Geçersiz kapı sayısı
        Araba araba2 = new Araba("Ford", "Fiesta", "Mavi", 3);
        Console.WriteLine($"Araba 2: {araba2.Marka} {araba2.Model}, Renk: {araba2.Renk}, Kapı Sayısı: {araba2.KapıSayısı}");
    }
}
