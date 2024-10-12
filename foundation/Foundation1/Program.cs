using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {

        // Assume you have been hired by a company that monitors product awareness by tracking the placement of their products in YouTube videos. They want you to write a program that can help them work with the tens of thousands of videos they have identified as well as the comments on them.//
        // Once you have the classes in place, write a program that creates 3-4 videos, 
        //sets the appropriate values, and for each one add a list of 3-4 comments 
        //(with the commenter's name and text). Put each of these videos in a list.

//video 01

        Comment comment1 = new Comment("Greice Moreira" , "Filme maravilhoso");
        Comment comment2 = new Comment("Isabella Moreira" , "Quero saber o final");
        Comment comment3 = new Comment( "Helena Moreira" , "Cade o bebe yoda? ops grogu");

        Video video1 = new Video("Start Wars" ,"George Lucas" , 120 );
        video1.AddInListOfComments(comment1);
        video1.AddInListOfComments(comment2);
        video1.AddInListOfComments(comment3);

 //video 02
        Comment comment4 = new Comment("Greice Moreira" , "Musicas muito boas");
        Comment comment5 = new Comment("Isabella Moreira" , "Prefiro o primeiro");
        Comment comment6 = new Comment( "Helena Moreira" , "Quero um vestido igual");

        Video video2 = new Video("Frozen 2" ,"Disney" , 110 );
        video2.AddInListOfComments(comment4);
        video2.AddInListOfComments(comment5);
        video2.AddInListOfComments(comment6);

 //video 03
        Comment comment7 = new Comment("Greice Moreira" , "amo amo amo");
        Comment comment8 = new Comment("Isabella Moreira" , "Podemos ver o proximo?");
        Comment comment9 = new Comment( "Helena Moreira" , "Podemos ver o proximo?");

        Video video3 = new Video("Harry Potter" ,"J. K. Rolling" , 130 );
        video3.AddInListOfComments(comment7);
        video3.AddInListOfComments(comment8);
        video3.AddInListOfComments(comment9);

 //video 04
        Comment comment10 = new Comment("Greice Moreira" , "Classico");
        Comment comment11 = new Comment("Isabella Moreira" , "Maravilhoso");
        Comment comment12 = new Comment( "Helena Moreira" , "Mais uma vez");

        Video video4 = new Video("Rei Leao" ,"Disney" , 100 );
        video4.AddInListOfComments(comment10);
        video4.AddInListOfComments(comment11);
        video4.AddInListOfComments(comment12);

        
        List<Video> videos = new List<Video> { video1, video2, video3 , video4};

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine("Comments:");
            foreach (Comment c in video.GetComments())
            {
                Console.WriteLine(c.GetComment());
            }
            Console.WriteLine($"Total of Comments: {video.NumberOfComments()}");
            Console.WriteLine();
        }



        //Then, have your program iterate through the list of videos and for each one, 
        //display the title, author, length, number of comments (from the method) and 
        //then list out all of the comments for that video. Repeat this display for each video in the list.
    }
}