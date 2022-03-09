namespace Movie.Data.Models;

using System.ComponentModel.DataAnnotations.Schema;

[Table("numbers")]
public class NumberDataModel : EntityDataModel
{
    [Column("movie_id")]
    public long MovieId { get; set; }

    public long ReleaseDate { get; set; }

    public int Runtime { get; set; }

    public string Rating { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [ForeignKey("MovieId")]
    public virtual MovieDataModel Movie { get; set; } = new MovieDataModel();
}