using System.IO;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    private static void Main(string[] args)
    {
        List<string> girdiler=new List<string>();
        string[] dosyalar = Directory.GetFiles("C:\\Users\\rtf34\\Desktop\\fotolar");
        foreach (string dosya in dosyalar) 
        {
            if (dosya.EndsWith(".jpg") || dosya.EndsWith(".JPG") || dosya.EndsWith(".jpeg") || dosya.EndsWith(".png"))
            {
                if (dosya.Contains(".remini-enhanced"))
                {
                    try
                    {
                        var yeniad = dosya.Replace(".remini-enhanced", "");
                        File.Copy(dosya, yeniad);
                    }
                    catch 
                    {

                        
                    }
                  
                }
            
            }

          
        }

        Console.WriteLine("Hello, World!");
    }

}


    