using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers;

[ApiController]
[Route("[controller]")]
public class AlbumsController : ControllerBase
{
    private static readonly Album[] Albums = new[]
    {
        new Album{ ID="1", Title="Blue Train", Artist="John Coltrane", Price=56.99},
        new Album{ ID="2", Title="Jeru", Artist="Gerry Mulligan", Price=17.99},
        new Album{ ID="3", Title="Sarah Vaughan and Clifford Brown", Artist="Sarah Vaughan", Price=39.99}
    };

    public IEnumerable<Album> Get()
    {
        return Albums;
    }
}

public record Album
{
    public string? ID { get; set; }
    public string? Title { get; set; }
    public string? Artist { get; set; }
    public double Price { get; set; }
}