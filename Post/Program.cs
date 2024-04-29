using Post.Entities;

namespace Post;

class Program
{
    static void Main(string[] args)
    {
        Comment c1 = new Comment("Have a nice trip!");
        Comment c2 = new Comment("Wow thas's awasome");
        Posts p1 = new Posts(DateTime.Parse("21/06/2024 13:05:44"), "Traveling to New Zeland", "I'm going to visit this wonderful country!", 12);
        
        p1.AddComment(c1);
        p1.AddComment(c2);
        
        Comment c3 = new Comment("Good night");
        Comment c4 = new Comment("May the Force be with you");
        Posts p2 = new Posts(DateTime.Parse("28/07/2018 23:14:19"), "Good night guys", "See you tomorrow", 5);
        p2.AddComment(c3);
        p2.AddComment(c4);

        Console.WriteLine(p1);
        Console.WriteLine(p2);
        
    }
}