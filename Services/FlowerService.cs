using System.Text.Json;

public class FlowerService(IWebHostEnvironment webHostEnvironment)
{
    private readonly IWebHostEnvironment webHostEnvironment = webHostEnvironment;

    public string JsonFileName {
        get {
            return Path.Combine(this.webHostEnvironment.WebRootPath, "flowers.json");
        }
    }

    public IEnumerable<Flower>? GetFlowers() {
        var jsonFileReader = File.OpenText(JsonFileName);
        return JsonSerializer.Deserialize<Flower[]>(jsonFileReader.ReadToEnd(), 
        new JsonSerializerOptions {PropertyNameCaseInsensitive = true});
    }
}