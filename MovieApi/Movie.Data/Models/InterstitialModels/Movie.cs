namespace Movie.Data.Models;

using System.Collections.Generic;

public class Movie : Entity {
    public string? Title { get; set; }

    public string? Image { get; set; }

    public string? Description { get; set; }

    public List<Actor> Actor { get; set; } = new List<Actor>();
    public List<Numbers> Numbers { get; set; } = new List<Numbers>();
}
