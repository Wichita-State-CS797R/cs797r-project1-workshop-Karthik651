using System.Text.Json.Serialization;

namespace MonkeyFinder.Model;

public class Monkey
{
    public string Name { get; set; }

    public string Age { get; set; }

    public string Location { get; set; }
}