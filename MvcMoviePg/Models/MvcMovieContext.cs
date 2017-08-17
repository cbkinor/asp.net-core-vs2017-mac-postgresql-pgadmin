using System;
using Microsoft.EntityFrameworkCore;

namespace MvcMoviePg.Models
{

	public class MvcMovieContext : DbContext
	{
		public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
			: base(options)
		{
		}

		public DbSet<MvcMoviePg.Models.Movie> Movie { get; set; }
	}
}
