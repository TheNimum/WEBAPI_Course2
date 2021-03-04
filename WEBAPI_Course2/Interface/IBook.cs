namespace WEBAPI_Course2.Interface
{
    public interface IBook
    {
        int Id { get; set; }
        string Author { get; set; }
        string Titel { get; set; }
        string Category { get; set; }

    }
}
