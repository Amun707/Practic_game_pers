namespace Practic_game_pers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person<int> tom = new Person<int>(546, "Tom");
            Person<string> bob = new Person<string>("abc123", "Bob");
            int tomId = tom.Id;
            string bobId = bob.Id;

            Console.WriteLine(tomId);  // 546
            Console.WriteLine(bobId);  // abc123



            Sword sword = new("ajsd", 50, "BadaBums", "Еще что то");
            TheGamePers<Sword> SAN = new TheGamePers<Sword>("San", "Чубака", sword);
            sword.Print();
            Console.WriteLine(SAN.ToString());
        }

            class ClassName<T1, T2>
        {
            //реализация методов и полей класса
            //которые работают с обобщёнными типами Т1,Т2,...ТN
            public T1 Id { get; }
            public T2 Password { get; set; }
            public string Name { get; set; }
            public ClassName(T1 id, T2 password, string name)
            {
                Id = id;
                Name = name;
                Password = password;
            }
        }

        class Person<T>
        {
            public T Id { get; set; }
            public string Name { get; set; }
            public Person(T id, string name)
            {
                Id = id;
                Name = name;
            }
        }
    }

    internal class TheGamePers<T>
    {
        private string v1;
        private string v2;
        private Sword sword;

        public TheGamePers(string v1, string v2, Sword sword)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.sword = sword;
        }
    }
}
}
