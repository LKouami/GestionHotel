using GestionHotel.API.Helpers;
using GestionHotel.API.PipelineBehaviors;
using GestionHotel.Data.IRepositories;
using GestionHotel.Data.Repositories;
using GestionHotel.Model;
using GestionHotel.Domain.Dxos;
using GestionHotel.Service.Services.Helpers;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using GestionHotel.Model.Models;

namespace GestionHotel.API.App_Start
{
    public static class Dependencies_Start
    {

        /// <summary>
        /// Resolve all the dependencies in the application
        /// </summary>
        /// <param name="services"></param>
        /// <param name="Configuration"></param>
        public static void ResolveDepenciesServices(this IServiceCollection services, IConfiguration Configuration)
        {
            // //Sql server 
            // //master database
            // services.AddDbContext<GestionHotel_Master_DbContext>(options =>
            // {
            //     options.UseSqlServer(Configuration.GetConnectionString("MasterConnection"),
            //         sqlOptions =>
            //         {
            //             sqlOptions.EnableRetryOnFailure(maxRetryCount: 3, maxRetryDelay: TimeSpan.FromSeconds(30),
            //                 errorNumbersToAdd: null);
            //         });
            // });

            //Add connection string based on the tenant. Pick the tenantid in the header
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddDbContext<NoyauxButlerDBContext>((serviceProvider, options) =>
            {
                var httpContext = serviceProvider.GetService<IHttpContextAccessor>().HttpContext;
                var httpRequest = httpContext.Request;
                var connection = GetConnection(httpRequest, Configuration);
                options.UseSqlServer(connection, sqlOptions =>
                {
                    sqlOptions.EnableRetryOnFailure(maxRetryCount: 3, maxRetryDelay: TimeSpan.FromSeconds(30),
                        errorNumbersToAdd: null);
                });
            });




            //Add DIs



            //User
            services.AddScoped<ITokenHelper, TokenHelper>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserDxos, UserDxos>();

            
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IClientDxos, ClientDxos>();

            services.AddScoped<IPackRepository, PackRepository>();
            services.AddScoped<IPackDxos, PackDxos>();

            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IRoleDxos, RoleDxos>();

            services.AddScoped<IAffectationMaterielRepository, AffectationMaterielRepository>();
            services.AddScoped<IAffectationMaterielDxos, AffectationMaterielDxos>();

            services.AddScoped<IAffectationMaterielvueRepository, AffectationMaterielvueRepository>();
            services.AddScoped<IAffectationMaterielvueDxos, AffectationMaterielvueDxos>();

            services.AddScoped<IClientvueRepository, ClientvueRepository>();
            services.AddScoped<IClientvueDxos, ClientvueDxos>();

            services.AddScoped<ILocationvueRepository, LocationvueRepository>();
            services.AddScoped<ILocationvueDxos, LocationvueDxos>();

            services.AddScoped<IEspacevueRepository, EspacevueRepository>();
            services.AddScoped<IEspacevueDxos, EspacevueDxos>();

            services.AddScoped< IEspaceRepository, EspaceRepository>();
            services.AddScoped<IEspaceDxos, EspaceDxos>();

            services.AddScoped<IOrganismePayeurRepository, OrganismePayeurRepository>();
            services.AddScoped<IOrganismePayeurDxos, OrganismePayeurDxos>();

            services.AddScoped<IEtatEspaceRepository, EtatEspaceRepository>();
            services.AddScoped<IEtatEspaceDxos, EtatEspaceDxos>();



            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<ILocationDxos, LocationDxos>();

            services.AddScoped<IMaterielRepository, MaterielRepository>();
            services.AddScoped<IMaterielDxos, MaterielDxos>();

           

            services.AddScoped<ITypeClientRepository, TypeClientRepository>();
            services.AddScoped<ITypeClientDxos, TypeClientDxos>();

            services.AddScoped<ITypeEspaceRepository, TypeEspaceRepository>();
            services.AddScoped<ITypeEspaceDxos, TypeEspaceDxos>();

           


            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

        }

        private static string GetConnection(HttpRequest httpRequest, IConfiguration Configuration)
        {
            string tenantId = httpRequest.Headers["TenantId"].ToString();

            Console.WriteLine($"TenantId: {tenantId}");

            if (!string.IsNullOrWhiteSpace(tenantId))
            {
                return Configuration.GetConnectionString("DefaultConnection").Replace("{TenantId}", tenantId);
            }
            else
            {
                return Configuration.GetConnectionString("DefaultConnection").Replace("_{TenantId}", "");
            }


        }
    }
}
