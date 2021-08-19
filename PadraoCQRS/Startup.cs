using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Reflection;

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
			services.AddMediatR(Assembly.GetExecutingAssembly());

			services.AddSwaggerGen(c => {
				c.SwaggerDoc("v1",
					new OpenApiInfo
					{
						Title = "REST API's documentação",
						Version = "v1",
						Description = "api CQRS",
						Contact = new OpenApiContact
						{
							Name = "Magno Moreira",
							Url = new Uri("https://github.com/magnomoreia")
						}
					});
			});
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

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
