using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Swashbuckle.AspNetCore.Swagger;
using QCloudIM.AspNetCore;
using QCloudIM.AspNetCore.Options;
using QCloudIM.AspNetCore.Utility;

namespace WebApplicationSample
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddQCloudIM(options =>
            {
                //options.SdkAppid = "1400487952";
                //options.Expire = 86400;
                //options.PrivateKey =
                //    "4f10a10198d830320996490f5298c4de9da8d6c68f9086bd63284556fd4a47bc";
                //options.Identifier = "administrator";

                options.SdkAppid = "1400238850";
                options.Expire = 86400;
                options.PrivateKey =
                   @"MIGHAgEAMBMGByqGSM49AgEGCCqGSM49AwEHBG0wawIBAQQgAsprDlUaUF4f43Nx BDwiKRR1hOV6vocdzqptUXO2tcihRANCAASTiKe5f8ZLaM1WAw36I2JNlfgBX3Zb 474P3DsKl+4pIakzsbTU0e/EbjMxbJU1eZTUIUDasM+6Ij+WwK9NJcrp
                   ";
                options.Identifier = "admin";
                //options.Version = "v1";
            });

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "腾讯云服务端测试文档", Version = "v1" });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();

            app.UseRouting();

            //启用中间件服务生成Swagger作为JSON终结点
            app.UseSwagger();
            //启用中间件服务对swagger-ui，指定Swagger JSON终结点
            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = string.Empty;
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApplicationSample");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("defaultWithArea", "{area}/{controller=Home}/{action=Index}/{id?}");
            });
          
        }
    }
}
