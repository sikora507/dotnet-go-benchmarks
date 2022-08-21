var builder = WebApplication.CreateBuilder(args);

var albums = new[]
{
    new Album{ ID="1", Title="Blue Train", Artist="John Coltrane", Price=56.99},
    new Album{ ID="2", Title="Jeru", Artist="Gerry Mulligan", Price=17.99},
    new Album{ ID="3", Title="Sarah Vaughan and Clifford Brown", Artist="Sarah Vaughan", Price=39.99}
};

var app = builder.Build();

app.MapGet("/albums", () => albums);

app.Run();

