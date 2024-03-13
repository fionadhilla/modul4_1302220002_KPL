using static KodeBuah;
using System;
public class KodeBuah
{
    private Dictionary<string, string> kodeBuah;


    public KodeBuah()
    {
        kodeBuah = new Dictionary<string, string>
        {
            {"Apel", "A00"},
            {"Aprikot", "B00"},
            {"Alpukat", "C00"},
            {"Pisang", "D00"},
            {"Paprika", "E00"},
            {"Blackberry", "F00"},
            {"Ceri", "H00"},
            {"Kelapa", "I00"},
            {"Jagung", "J00"},
            {"Kurma", "K00"},
            {"Durian", "L00"},
            {"Anggur", "M00"},
            {"Melon", "N00"},
            {"Semangka", "O00"}
            
        };

        
    }
    public string GetKodePos(string buah)
    {
        if (kodeBuah.ContainsKey(buah))
        {
            return kodeBuah[buah];
        }
        else
        {
            return "Kode Pos Tidak Ditemukan";
        }
    }
}


class Program
{
    static void Main(string[] args)
    {

        KodeBuah kodePosObj = new KodeBuah();
        string kelurahan = "Apel";
        string kodePos = kodePosObj.GetKodePos(kelurahan);
        Console.WriteLine($"Kode Pos {kelurahan}: {kodePos}");

    }
}
