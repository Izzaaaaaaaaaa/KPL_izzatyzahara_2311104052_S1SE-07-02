using System;
using System.Collections.Generic;

    public class SayaTubeUser
    {
        private int id;
        private string Username;
        private List<SayaTubeVideo> uploadedVideos;

        public SayaTubeUser(string username)
        {
            if (string.IsNullOrEmpty(username) || username.Length > 100)
                throw new ArgumentException("Username tidak boleh kosong dan maksimal 100 karakter.");

            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.Username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public void AddVideo(SayaTubeVideo video)
        {
            if (video == null)
                throw new ArgumentNullException(nameof(video), "Video tidak boleh null.");

            uploadedVideos.Add(video);
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach (var video in uploadedVideos)
            {
                total += video.GetPlayCount();
            }
            return total;
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine($"User: {Username}");
            int index = 1;
            foreach (var video in uploadedVideos)
            {
                if (index > 8) break; // Maksimal print 8 video
                Console.WriteLine($"Video {index} judul: {video.GetTitle()}");
                index++;
            }
        }
    }