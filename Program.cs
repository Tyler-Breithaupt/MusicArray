namespace FunWithMusic;

class Program
{
    enum Genre
    {
        Hiphop,
        Pop,
        Rock,
        Country,
        Jazz
    }
    struct Music
    {
        private string Title;
        private string Artist;
        private string Album;
        private string Length;
        private Genre? Genre;

        /*public Music(string title, string artist, string album, string length, Genre genre)
        {
            Title = title;
            Artist = artist;
            Album = album;
            Length = length;
            Genre = genre;
        }*/
        public void setTitle(string title)
        {
            Title = title;
        }
        public void setArtist(string artist)
        {
            Artist = artist;
        }
        public void setAlbum(string album)
        {
            Album = album;
        }
        public void setLength(string length)
        {
            Length = length;
        }
        public void setGenre(Genre genre)
        {
            Genre = genre;
        }
        public string Display()
        {
            return "Title: " + Title + "\nArtist: " + Artist + "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("How many songs would you like to enter?");
        int size = int.Parse(Console.ReadLine());
        Music[] collection = new Music[size];
        try
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Please enter the song title?");
                collection[i].setTitle(Console.ReadLine());
                Console.WriteLine("Who is the artist?");
                collection[i].setArtist(Console.ReadLine());
                Console.WriteLine("Which album is the song on?");
                collection[i].setAlbum(Console.ReadLine());
                Console.WriteLine("What is the length of the song?");
                collection[i].setLength(Console.ReadLine());
                Console.WriteLine("What is the genre?");
                Console.WriteLine("H - Hip hop\nP - Pop\nR - Rock\nC - Country\nJ - Jazz");
                Genre tempGenre = Genre.Hiphop;
                char g = char.Parse(Console.ReadLine());
                switch (g)
                {
                    case 'H':
                        tempGenre = Genre.Hiphop;
                        break;
                    case 'P':
                        tempGenre = Genre.Pop;
                        break;
                    case 'R':
                        tempGenre = Genre.Rock;
                        break;
                    case 'C':
                        tempGenre = Genre.Country;
                        break;
                    case 'J':
                        tempGenre = Genre.Jazz;
                        break;
                }
                collection[i].setGenre(tempGenre);
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"{collection[i].Display()}");
            }
        }
    }
}