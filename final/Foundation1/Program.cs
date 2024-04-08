using System;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Hello Foundation1 World!
        Videos and Comments Abstraction Foundation");
        Console.WriteLine();

        

        List<Video> videos = new List<Video>
        {
            new Video("How to be a self-taught programmer", "Kuya Dev", 120),
            new Video("Inheritance in C#", "Bro Code", 150 )

        };

        videos[0].AddComment("Bro Code", "Great video!");
        videos[0].AddComment("CodeAcad", "Awesome video");
        videos[1].AddComment("Code Acad", "Great Tutorial");


        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title()}");
            Console.WriteLine($"Author: {video.Author()}");
            Console.WriteLine($"Length: {video.Length()} seconds");
            Console.WriteLine($"Number of comments: {video.NumberOfComments()}");


            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.UserName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}