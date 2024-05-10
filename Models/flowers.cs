using System.Text.Json;
using System.Text.Json.Serialization;

public class Flower {
    public string? Id { get; set; }
    public string? ProductName { get; set; }
    public string? Description { get; set; }
    [JsonPropertyName("imgURI")]
    public string? Img { get; set; }
    public string? Price { get; set; }

    public override string ToString() => JsonSerializer.Serialize<Flower>(this);
}