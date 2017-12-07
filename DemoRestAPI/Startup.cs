using DemoBLL;
using DemoBLL.BusinessObjects;
using DemoBLL.Facade;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace CustomerRestAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.WithOrigins("http://localhost:4200")
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            services.AddSingleton(Configuration);
            services.AddScoped<IBLLFacade, BLLFacade>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {


            if (env.IsDevelopment())
            {
                loggerFactory.AddConsole(Configuration.GetSection("Logging"));
                loggerFactory.AddDebug();

                app.UseDeveloperExceptionPage();

                var facade = new BLLFacade(Configuration);

                string[] Ingredients = {

"Protein",
"Fedt",
"mættede fedtsyrer",
"monoumætt fedtsyrer",
"polyumætt fedtsyrer",
"Kulhydrat",
"sukker",
"kostfibre",
"Alkohol",
"Aske",
"Vand",
"A-vitamin",
"Retinol",
"β-caroten",
"D-vitamin",
"cholecalciferol",
"ergocalciferol",
"hydroxycholecalciferol",
 "E-vitamin",
"alfa-tokoferol",
"K-vitamin",
"B1-vitamin",
"B2-vitamin",
"Niacin",
"niacin",
"tryptofans",
"B6-vitamin",
"Pantothensyre",
"Biotin",
"Folat",
"B12-vitamin",
"C-vitamin",
"Natrium",
"Kalium",
"Calcium",
"Magnesium",
"Phosphor",
"Jern",
"Kobber",
"Zink",
"Jod",
"Mangan",
"Chrom",
"Selen",
"Nikkel",
"Fructose",
"Glucose",
"Lactose",
"Maltose",
"Saccharose",
"Sukkerarter",
"Stivelse",
"Kostfibre",
"Transfedtsyrer",
"Cholesterol",
"Isoleucin",
"Leucin",
"Lysin",
"Methionin",
"Cystin",
"Phenylalanin",
"Tyrosin",
"Threonin",
"Tryptofan",
"Valin",
"Arginin",
"Histidin",
"Alanin",
"Asparaginsyre",
"Glutaminsyre",
"Glycin",
"Prolin",
"Serin",

            };
                foreach (string ind in Ingredients)
                {
                    var Igredient = facade.IngredientService.Create(
                     new IngredientBO()
                     {
                         Name = "" + ind
                     });
                }






            }

            app.UseMvc();
        }
    }
}

