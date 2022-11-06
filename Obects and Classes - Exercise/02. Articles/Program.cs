namespace _02._Articles
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ");
            Article article = new Article(input[0], input[1], input[2]);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmndArgs = Console.ReadLine()
                    .Split(": ");
                string type = cmndArgs[0];
                string value = cmndArgs[1];

                switch (type)
                {
                    case "Edit":
                        article.Edit(value);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(value);
                        break;
                    case "Rename":
                        article.Rename(value);
                        break;
                }
            }
            Console.WriteLine(article.ToString());
        }
    }
    public class Article
    { 
        public Article(string title, string content,string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string content)
        {
            Content = content;
        }

        public void ChangeAuthor(string author)
        {
            Author = author;
        }

        public void Rename(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
