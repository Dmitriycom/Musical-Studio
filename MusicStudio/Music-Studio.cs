using System;

namespace MusicStudio
{
    public class Human
    {
        private string name;
        private string surname;
        private int age;

        public Human(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }

    public class Singer : Human
    {
        public int idSinger { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public Singer(string name, string surname, int age, int idSinger, string phoneNumber, string email, string gender): 
            base(name, surname, age)
        {
            this.idSinger = idSinger;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.gender = gender;
        }
    }

    public class Song
    {
        public int idSong { get; set; }
        public int idSinger { get; set; }
        public string nameSong { get; set; }
        public string nameAlbum { get; set; }
        public string timeSong { get; set; }
        public string genre { get; set; }

        public Song(int idSong, int idSinger, string nameSong, string nameAlbum, string timeSong, string genre)
        {
            this.idSong = idSong;
            this.idSinger = idSinger;
            this.nameSong = nameSong;
            this.nameAlbum = nameAlbum;
            this.timeSong = timeSong;
            this.genre = genre;
        }
    }

}
