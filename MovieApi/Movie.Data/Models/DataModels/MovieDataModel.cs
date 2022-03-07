namespace Movies.Data.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

[Table("movie")]

public class MovieDataModel : EntityDataModel
{
    public string Title { get; set; } = string.Empty;

    public string Image { get; set;} = string.Empty;

    public string Description {get; set;} = string.Empty;

}