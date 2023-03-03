using Maestro.Application.Infrastructure.Binder;
using Maestro.Application.Infrastructure.Converter.Json.Spatial;
using Maestro.Infrastructure;
using Maestro.Persistence;
using Microsoft.OpenApi.Models;

namespace Maestro.API
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {

            services.AddPersistenceServices(Configuration);
            services.AddInfrastructureServices();

            services
                .AddControllers(opts =>
                {
                    opts.ModelBinderProviders.Insert(0, new GeometryModelBinderProvider());
                })
                .AddNewtonsoftJson()
                .AddJsonOptions(opts =>
                {
                    opts.JsonSerializerOptions.Converters.Add(new Application.Infrastructure.Converter.Json.Spatial.GeometryConverter());
                    opts.JsonSerializerOptions.Converters.Add(new PolygonConverter());
                    opts.JsonSerializerOptions.Converters.Add(new PointConverter());
                    opts.JsonSerializerOptions.Converters.Add(new LineStringConverter());
                });

            //  services.AddAutoMapper(typeof(Startup));

            //  var mapperConfig = new MapperConfiguration(mc =>
            //  {
            //      mc.AddProfile(new ShUserProfile());
            //  });

            //  IMapper mapper = mapperConfig.CreateMapper();
            //  services.AddSingleton(mapper);

            services.AddSwaggerGen(opts =>
            {
                opts.SwaggerDoc("v1", new OpenApiInfo { Title = "Maestro.API", Version = "v1" });
                opts.DocInclusionPredicate((docName, description) => true);
                opts.CustomSchemaIds(type => type.FullName);
                opts.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseHsts();
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Maestro.WebAPI v1"));
            }

            app.UseRouting();
            app.UseStaticFiles();
            app.UseAuthorization();
            app.UseHttpsRedirection();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
