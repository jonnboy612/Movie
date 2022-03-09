namespace Movie.Data.Models;

public class Numbers : Entity {
  public long MovieId { get; set; }

  public long ReleaseDate { get; set; }

  public int Runtime { get; set; }

  public string? Rating { get; set; }
}
