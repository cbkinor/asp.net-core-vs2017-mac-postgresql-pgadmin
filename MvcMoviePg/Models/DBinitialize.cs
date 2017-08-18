using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MvcMoviePg.Models
{
    public class DBinitialize
    {
		public static void EnsureCreated(IServiceProvider serviceProvider)
		{
			var context = new MvcMovieContext(
				serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>());
			context.Database.EnsureCreated();
		}
    }
}
