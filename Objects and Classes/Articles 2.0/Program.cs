using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Article> colection = new List<Article>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                Article article = new Article(command[0], command[1], command[2]);
                colection.Add(article);
            }
            string orderBY = Console.ReadLine();

            if (orderBY == "title")
            {
                Console.WriteLine(String.Join("\n", colection.OrderBy(x => x.Title)));
            }
            else if (orderBY == "content")
            {
                Console.WriteLine(String.Join("\n", colection.OrderBy(x => x.Content)));
            }
            else if (orderBY == "author")
            {
                Console.WriteLine(String.Join("\n", colection.OrderBy(x => x.Author)));
            }



        }
        public class Article
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public Article(string title, string content, string author)
            {

                this.Content = content;
                this.Title = title;
                this.Author = author;
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}
