using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using PadraoCQRS.Data;
using PadraoCQRS.Domain.Commands;
using PadraoCQRS.Repository;
using System;

namespace PadraoCQRS
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();
			services.AddSwaggerGen(c => {
				c.SwaggerDoc("v1",
					new OpenApiInfo
					{
						Title = "REST API's documenta��o",
						Version = "v1",
						Description = "api CQRS",
						Contact = new OpenApiContact
						{
							Name = "Magno Moreira",
							Url = new Uri("https://github.com/magnomoreia")
						}
					});
			});

			var connection = Configuration["SqlServerConnection:ServerConnectionString"];
			services.AddDbContext<AplicationContext>(options => options.UseSqlServer(connection));

			services.AddScoped<CustumerRepository>();
			services.AddScoped<CreateCustumerHandler>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseSwagger();

			app.UseSwaggerUI(c => {
				c.SwaggerEndpoint("/swagger/v1/swagger.json",
					"REST API's ");
			});

			var option = new RewriteOptions();
			option.AddRedirect("^$", "swagger");
			app.UseRewriter(option);

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
