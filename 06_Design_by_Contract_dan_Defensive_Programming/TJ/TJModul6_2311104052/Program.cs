using System;

class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Iza");

        string[] judulFilm = {
            "Review Film Interstellar oleh Iza",
            "Review Film Inception oleh Iza",
            "Review Film The Dark Knight oleh Iza",
            "Review Film Parasite oleh Iza",
            "Review Film Avengers: Endgame oleh Iza",
            "Review Film Spider-Man: No Way Home oleh Iza",
            "Review Film The Matrix oleh Iza",
            "Review Film Whiplash oleh Iza",
            "Review Film La La Land oleh Iza",
            "Review Film Joker oleh Iza"
        };

        foreach (var judul in judulFilm)
        {
            SayaTubeVideo video = new SayaTubeVideo(judul);
            user.AddVideo(video);
        }

        user.PrintAllVideoPlaycount();

        // Menguji pengecekan overflow pada IncreasePlayCount
        SayaTubeVideo testVideo = new SayaTubeVideo("Test Video");
        try
        {
            testVideo.IncreasePlayCount(5000);
            testVideo.IncreasePlayCount(30000000); // Ini akan menimbulkan error
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        testVideo.PrintVideoDetails();

        Console.ReadLine();
    }
}
