using KinopoiskClone.Models;
using Microsoft.EntityFrameworkCore;

namespace KinopoiskClone.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated(); 
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Интерстеллар", Year = 2014, PosterUrl = "https://tse2.mm.bing.net/th/id/OIP.gxz_8yynINMFV1RjIx13VgHaKX?r=0&rs=1&pid=ImgDetMain&o=7&rm=3", Description = "Исследователи отправляются за пределы галактики." },
                new Movie { Id = 2, Title = "Тёмный рыцарь", Year = 2008, PosterUrl = "https://zefirka.club/uploads/posts/2022-10/1666869035_39-zefirka-club-p-temnii-ritsar-poster-51.jpg", Description = "Бэтмен противостоит криминальному гению Джокеру." },
                new Movie { Id = 3, Title = "Начало", Year = 2010, PosterUrl = "https://1080-kino.com/uploads/posts/2020-12/1606812655-1489444460.jpg", Description = "Вор, крадущий корпоративные секреты через сны." },
                new Movie { Id = 4, Title = "Матрица", Year = 1999, PosterUrl = "https://tse1.mm.bing.net/th/id/OIP.MUBHmXoV2aj5Vfyi5J2PrwAAAA?r=0&rs=1&pid=ImgDetMain&o=7&rm=3", Description = "Хакер Нео узнает истинную природу реальности." },
                new Movie { Id = 5, Title = "Криминальное чтиво", Year = 1994, PosterUrl = "https://tse3.mm.bing.net/th/id/OIP.L2_FcecJ3vNyJvxqPtkYdAHaJw?r=0&rs=1&pid=ImgDetMain&o=7&rm=3", Description = "Истории наемных убийц, гангстера и его жены." },
                new Movie { Id = 6, Title = "Бойцовский клуб", Year = 1999, PosterUrl = "https://th.bing.com/th/id/R.7f2181d83052be863f4bf4eba9cb334c?rik=Ebd%2ft0fL%2frU8fg&pid=ImgRaw&r=0", Description = "Офисный работник организует подпольный клуб." },
                new Movie { Id = 7, Title = "Форрест Гамп", Year = 1994, PosterUrl = "https://ru-images.kinorium.com/movie/1080/99975.jpg?1746286277", Description = "История жизни человека с низким IQ." },
                new Movie { Id = 8, Title = "Властелин колец", Year = 2001, PosterUrl = "https://tse1.mm.bing.net/th/id/OIP.nuM7miUT1he1iDZnfsyXhwHaLH?r=0&rs=1&pid=ImgDetMain&o=7&rm=3", Description = "Братство отправляется в Мордор." },
                new Movie { Id = 9, Title = "Побег из Шоушенка", Year = 1994, PosterUrl = "https://kinoafisha.ua/upload/films/3941/1330076405pobeg-iz-shoushenka.jpg", Description = "Банкир ищет свободу и надежду в тюрьме." },
                new Movie { Id = 10, Title = "Гладиатор", Year = 2000, PosterUrl = "https://ru-images.kinorium.com/movie/1080/143897.jpg?1678576575", Description = "Римский генерал сражается на арене Колизея." }
            );
        }
    }
}