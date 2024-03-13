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

public enum posisiskarakter
{
    jongkok,
    berdiri,
    terbang,
    tengkurap
}

public class POsisiKarakterGame
{
    private posisiskarakter currentState;

    public POsisiKarakterGame()
    {
        currentState = posisiskarakter.berdiri;
    }

    public void TombolW()
    {
        if(currentState == posisiskarakter.tengkurap)
        {
            currentState = posisiskarakter.jongkok;
            Console.WriteLine("POSISI SEKARANG: JONGKOK");
        }
        else if(currentState == posisiskarakter.jongkok)
        {
            currentState = posisiskarakter.berdiri;
            Console.WriteLine("POSISI SEKARANG: BERDIRI");
        } 
        else if(currentState == posisiskarakter.berdiri)
        {
            currentState = posisiskarakter.terbang;
            Console.WriteLine("POSISI SEKARANG: TERBANG");
            Console.WriteLine("POSISI TAKE OFF");                   
        } 
        else
        {
            Console.WriteLine("PERINTAH TIDAK VALID");
        }
        //Console.WriteLine("Pintu tidak terkunci");
    }

    public void TombolS()
    {
        if (currentState == posisiskarakter.terbang)
        {
            currentState = posisiskarakter.berdiri;
            Console.WriteLine("POSISI SEKARANG: BERDIRI");
        }
        else if (currentState == posisiskarakter.berdiri)
        {
            currentState = posisiskarakter.jongkok;
            Console.WriteLine("POSISI SEKARANG: JONGKOK");
        }
        else if (currentState == posisiskarakter.jongkok)
        {
            currentState = posisiskarakter.tengkurap;
            Console.WriteLine("POSISI SEKARANG: TENGKURAP");
        }
        else
        {
            Console.WriteLine("PERINTAH TIDAK VALID");
        }
    }

    public void Tombolx()
    {
        if (currentState == posisiskarakter.terbang)
        {
            currentState = posisiskarakter.jongkok;
            Console.WriteLine("POSISI LANDING");
            Console.WriteLine("POSISI SEKARANG: JONGKOK");
        }
        else
        {
            Console.WriteLine("PERINTAH TIDAK VALID");
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

        Console.WriteLine("");
        Console.WriteLine("posisi sekarang adalah berdiri");
        POsisiKarakterGame posisi = new POsisiKarakterGame();
        Console.WriteLine("menekan tombol S");
        posisi.TombolS();
        Console.WriteLine("menekan tombol S");
        posisi.TombolS();
        Console.WriteLine("menekan tombol W");
        posisi.TombolW();
        Console.WriteLine("menekan tombol W");
        posisi.TombolW();
        Console.WriteLine("menekan tombol W");
        posisi.TombolW();
        Console.WriteLine("menekan tombol x");
        posisi.Tombolx();

        //String input = "";
        //Console.WriteLine("masukkan input:");
        //while(input != "exit")
        //{
         //   if(input == "s")
          //  {
         //       Console.WriteLine("menekan tombol S");
         //       posisi.TombolS();
         //   }
         //   else if(input == "w")
         //   {
          //      Console.WriteLine("menekan tombol W");
          //      posisi.TombolW();
          //  }
         //   else if(input == "x")
          //  {
          //      Console.WriteLine("menekan tombol x");
          //      posisi.Tombolx();
          //  }
         //   
        //    Console.WriteLine("masukkan input:");
       // }


    }
}
