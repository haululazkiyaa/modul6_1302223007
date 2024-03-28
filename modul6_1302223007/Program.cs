using modul6_1302223007;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Review Film Tukang Haji Naik Bubur oleh Muhammad Haulul Azkiyaa");
        video1.IncreasePlayCount(120);
        video1.PrintVideoDetails();
        SayaTubeVideo video2 = new SayaTubeVideo("Review Film Doraemon The Movie oleh Muhammad Haulul Azkiyaa");
        video2.IncreasePlayCount(100);
        video2.PrintVideoDetails();
        SayaTubeVideo video3 = new SayaTubeVideo("Review Film Jejak Si Gundul oleh Muhammad Haulul Azkiyaa");
        video3.IncreasePlayCount(150);
        video3.PrintVideoDetails();
        SayaTubeVideo video4 = new SayaTubeVideo("Review Film KKN Di Desa Bojongsoang Haji oleh Muhammad Haulul Azkiyaa");
        video4.IncreasePlayCount(130);
        video4.PrintVideoDetails();
        SayaTubeVideo video5 = new SayaTubeVideo("Review Film One Piece oleh Muhammad Haulul Azkiyaa");
        video5.IncreasePlayCount(100);
        video5.PrintVideoDetails();
        SayaTubeVideo video6 = new SayaTubeVideo("Review Film Upin Ipin Hantu Durian oleh Muhammad Haulul Azkiyaa");
        video6.IncreasePlayCount(120);
        video6.PrintVideoDetails();
        SayaTubeVideo video7 = new SayaTubeVideo("Review Film Spidolman 2 oleh Muhammad Haulul Azkiyaa");
        video7.IncreasePlayCount(130);
        video7.PrintVideoDetails();
        SayaTubeVideo video8 = new SayaTubeVideo("Review Film Azab Indosair oleh Muhammad Haulul Azkiyaa");
        video8.IncreasePlayCount(120);
        video8.PrintVideoDetails();
        SayaTubeVideo video9 = new SayaTubeVideo("Review Film Pengabdi Kampus oleh Muhammad Haulul Azkiyaa");
        video9.IncreasePlayCount(115);
        video9.PrintVideoDetails();
        SayaTubeVideo video10 = new SayaTubeVideo("Review Film Jakarta Tenggelam 2050 oleh Muhammad Haulul Azkiyaa"); ;
        video10.IncreasePlayCount(115);
        video10.PrintVideoDetails();

        SayaTubeUser user1 = new SayaTubeUser("Muhammad Haulul Azkiyaa");
        user1.AddVideo(video1);
        user1.AddVideo(video2);
        user1.AddVideo(video3);
        user1.AddVideo(video4);
        user1.AddVideo(video5);
        user1.AddVideo(video6);
        user1.AddVideo(video7);
        user1.AddVideo(video8);
        user1.AddVideo(video9);
        user1.AddVideo(video10);

        user1.PrintAllVideoPlaycount();
        Console.WriteLine("Total pemutaran semua film: " + user1.getTotalVideoPlayCount() + " kali");
    }
}