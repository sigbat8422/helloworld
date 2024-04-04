public class MyClass
{
    public string Concat(string text)
    {
        DateTime currentTime = DateTime.Now;
        string date = currentTime.ToString("HH:mm:ss");
            return date+" Hello, "+text;
    }
}