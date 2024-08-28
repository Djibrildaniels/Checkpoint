namespace WebApplication4.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int Price { get; set; }
    public string Description { get; set; }
    public string CoverImage { get; set; }
    public int ISBN { get; set; }
}