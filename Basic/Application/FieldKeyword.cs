public class FieldKeywordDemo
{
    private string _name;
    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty.");
            _name = value;
        }
    }
    public string Email
    {
        get=>field;
        set
        {
            if (!value.Contains("@"))
                throw new ArgumentException("Invalid email address.");
            field = value;
        }
    }
    //Lazy initialization example
    private readonly Random _random = new();
    public int ID
    {
        get => field == 0 ? field = _random.Next(1, 1000) : field;
        set=> field = value;
    }


}