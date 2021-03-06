namespace Movie.Data.Models;

using System.ComponentModel.DataAnnotations.Schema;

[Table("actor")]
public class ActorDataModel : EntityDataModel
{
    [Column("movie_id")]
    public long MovieId { get; set; }

    public string firstName { get; set; } = string.Empty;

    public string lastName { get; set; } = string.Empty;

    public string Role { get; set;} = string.Empty;

    /// <summary>
    /// 
    /// </summary>
    [ForeignKey("MovieId")]
    public virtual MovieDataModel Movie { get; set; } = new MovieDataModel();
}