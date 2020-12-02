using System;

namespace Enum&IMDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Lord of the Rings\n2.The Shawshank Redemption\n3.The Dark Knight\n4.Fight Club\n5.The Godfather\nSelect the movie whose score you want to see: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Review score of your chosen movie:");
            switch (x)
            {
                case 1:
                    Console.Write((double)Movies.Lord of the Rings / 10);
                    break;
                case 2:
                    Console.Write((double)Movies.The Shawshank Redemption / 10);
                    break;
                case 3:
                    Console.Write((double)Movies.The Dark Knight / 10);
                    break;
                case 4:
                    Console.Write((double)Movies.Fight Club / 10);
                    break;
                case 5:
                    Console.Write((double)Movies.The Godfather / 10);
                    break;
            }
        }
    }
    enum Movies
    {
        Lord of the Rings = 89, The Shawshank Redemption = 93, The Dark Knight = 90, Fight Club = 88, The Godfather = 92
    }

}