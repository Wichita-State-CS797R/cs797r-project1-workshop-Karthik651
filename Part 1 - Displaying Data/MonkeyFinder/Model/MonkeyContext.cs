using System.Text.Json.Serialization;

namespace MonkeyFinder.Model;

[JsonSerializable(typeof(List<Monkey>))]
internal sealed partial class MonkeyContext : JsonSerializerContext
{

}
