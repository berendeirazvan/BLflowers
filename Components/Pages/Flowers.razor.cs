using Microsoft.AspNetCore.Components;

namespace BLFlowers.Components.Pages;

public partial class Flowers
{
    public IEnumerable<Flower>? flowers { get; private set; }
    [Inject]
    private FlowerService flowerService { get; set; }
    protected override async Task OnInitializedAsync()
    {
        flowers = flowerService.GetFlowers();
    }
}