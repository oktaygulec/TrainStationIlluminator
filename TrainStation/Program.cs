using System;

namespace TrainStation
{
    class Program
    {
        static int TotalLocation, TotalPath;
        static char[,] Paths;

        static void Main(string[] args)
        {
            while (true)
            {
                //Kullanıcıdan toplam konum ve yol sayısını al.
                //Get the total location number and total path number from the user.
                Console.Write("Enter the total location number: ");
                TotalLocation = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the total path number: ");
                TotalPath = Convert.ToInt32(Console.ReadLine());

                CreateStation(TotalPath, TotalLocation);
                PutLight(Paths, TotalPath, TotalLocation);
                CreateFixedStation(Paths, TotalPath, TotalLocation);
            }
        }

        //Örnek tren istasyonu yarat.
        //Create a sample train station.
        static void CreateStation(int tp, int tl)
        {
            Paths = new char[tp, tl];

            for (int i = 0; i < tp; i++)
            {
                for (int j = 0; j < tl; j++)
                {
                    /*
                    0 ile 2 arasında bir rastgele sayı yarat (bu sayı 0 veya 1 olacak)
                    bu sayıları * ya da - olarak dönüştür (* : boş ve - : lamba koyulmamış konum)
                    ve bu değerleri iki boyutlu bir dizi içerisine koy (bu dizi tren istasyonu olacaktır).
                    */
                    
                    /*
                    Create a random number between 0 and 2 (it is going to be 0 or 1) 
                    convert them to * or - (* is empty and - is unlit location)
                    and put them into a 2D Array which is a train station.
                    */
                    Random RN = new Random();
                    int RandomNumber = RN.Next(0, 2);

                    if (RandomNumber == 0)
                    {
                        Paths[i, j] = '*';
                    }
                    else
                    {
                        Paths[i, j] = '-';
                    }
                    Console.Write(Paths[i, j]);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }

        //Bulunduğum konum uygunsa, istasyonlara lamba koy.
        //Put lights at the stations if it is in the correct location.
        static void PutLight(char[,] path, int tp, int tl)
        {
            int totalStation = 0;

            for (int i = 0; i < tp; i++)
            {
                for (int j = 0; j < tl; j++)
                {
                    //Konumum istasyonsa ve daha önce istasyona uğramadıysam lamba koy.
                    //If my current location is a station and if I did not stop by any station before, then put a light.
                    if (path[i, j] == '-' && totalStation == 0)
                    {
                        path[i, j] = '+';
                        totalStation++;
                    }
                    //Konumum istasyonsa ve daha önce istasyona uğradıysam devam et.
                    //If my current location is a station and if I did stop by a station before, then continue.

                    else if (path[i, j] == '-' && totalStation > 0)
                    {
                        totalStation++;
                    }
                    //Konumum istasyon değilse ve daha önce istasyona uğradıysam bir önceki konuma lamba koy.
                    //If my current location is not a station and if I did stop by a station before, then put a light at the previous location.

                    else if (path[i, j] == '*' && totalStation > 0)
                    {
                        path[i, j - 1] = '+';
                        totalStation = 0;
                    }
                    //Konumum istasyonsa ve yolun sonundaysam lamba koy.
                    //If my current location is a station and if I am at the end of the path, then put a light.
                    if (path[i, j] == '-' && j == tl - 1)
                    {
                        path[i, j] = '+';
                        totalStation = 0;
                    }
                }
                totalStation = 0;
            }
        }

        //Verilen tren istasyonunu düzelt ve ekranda göster.
        //Fix the given train station and show on the screen.
        static void CreateFixedStation(char[,] path, int tp, int tl)
        {

            for (int i = 0; i < tp; i++)
            {
                for (int j = 0; j < tl; j++)
                {
                    Console.Write(path[i, j]);
                }
                Console.WriteLine("");
            }
        }
    }
}
