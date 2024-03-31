namespace LibraryManagerApi.Communication.Request;

public class RequestRegisterBookJson
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public enum Gender
    {
        Fiction,
        Drama,
        Horror
    }
    public int Price { get; set; }
    public int Quantity { get; set; }
}
