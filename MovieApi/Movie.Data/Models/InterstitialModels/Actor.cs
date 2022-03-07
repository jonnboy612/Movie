namespace Movies.Data.Models;

public class Actor : Entity {
    public long MovieId { get; set; }

    public string? firstName { get; set; }

    public string? lastName { get; set; }

    public string? Role { get; set; }
}