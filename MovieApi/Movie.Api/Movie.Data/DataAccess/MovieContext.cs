namespace Movie.Data.DataAccess;

using Movie.Data.Models;
using Microsoft.EntityFrameworkCore;

public class MovieContext : DbContext
{
    ///<summary>
    /// Database conenction string.
    ///</summary>
    private string ConnectionString { get; set; } = string.Empty;

    ///<summary>
    /// Movie Table
    ///</summary>
    public virtual DbSet<MovieDataModel>? Movie { get; set; }

    ///<summary>
    /// Actor Table
    ///</summary>

    public virtual DbSet<ActorDataModel>? Actor { get; set; }

     ///<summary>
    /// Number Table
    ///</summary>

    public virtual DbSet<NumbersDataModel>? Numbers { get; set; }

    ///<summary>
    /// Constructor
    ///</summary>

    public MovieContext(DbContextOptions<MovieContext> options)
        :base(options)
        {
        }


    ///<summary>
    /// Saves Changes
    ///</summary>
    public override int SaveChanges()
    {
        return base.SaveChanges();
    }

}