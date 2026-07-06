
using Biblioteca.Application.Ports.Out;
using Biblioteca.Application.UseCases;
using Biblioteca.Infrastructure.Persistence;
using Biblioteca.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Infrastructure.Config
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<BibliotecaDbContext>(options => options.UseSqlServer(connectionString));

            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<GetBooksUseCase>();

            return services;
        }
    }
}
