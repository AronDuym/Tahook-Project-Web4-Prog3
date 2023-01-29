using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Serilog;

using Tahook.DTO.Contracts;
using Tahook.Infrastructure;
using Tahook.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Tahook.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateBootstrapLogger();

            Log.Information("Starting up");

            try
            {
            var builder = WebApplication.CreateBuilder(args);

            builder.Host.UseSerilog((ctx, lc) => lc.WriteTo.Console()
                .Enrich.WithThreadId()
                .Enrich.WithThreadName()
                .Enrich.FromLogContext()
                .Enrich.WithProperty("Version", "1.0.0")
                .ReadFrom.Configuration(ctx.Configuration));

            // Add services to the container.
            builder.Services.AddDbContext<TahookContext>(options =>
                 options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), b => b.EnableRetryOnFailure()));

            // SignalR:
            builder.Services.AddSignalR(o =>
            {
                o.EnableDetailedErrors = true;
            });

           //------------------------------------------------------------------------------------------------------------
           //Services toevoegen
            //builder.Services.AddScoped<IVergaderruimteRepository, VergaderruimteRepository>();
            builder.Services.AddScoped<IAnswerRepository, AnswerRepository>();
            builder.Services.AddScoped<IGameTopicRepository, GameTopicRepository>();
            builder.Services.AddScoped<IQuestionRepository, QuestionRepository>();
            builder.Services.AddScoped<IQuizReportRepository, QuizReportRepository>();
            builder.Services.AddScoped<IQuizRepository, QuizRepository>();
            builder.Services.AddScoped<IRoleRepository, RoleRepository>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(
                /* options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "ThePlaceToMeet API V1");

                    options.OAuthAppName("ThePlaceToMeet API - Swagger");
                    options.OAuthClientId("interactive.public");
                    options.OAuthClientSecret("49C1A7E1-0C79-4A89-A3D6-A37998FB86B0");
                    options.OAuthScopeSeparator(" ");
                    options.OAuth2RedirectUrl("https://localhost:5005/Account/Login");                        
                    //options.OAuthUseBasicAuthenticationWithAccessCodeGrant();
                    options.OAuthUsePkce();
                }*/
                );
            }
            else
            {
                app.UseHsts(); // https
            }

            UseHeadersMiddleware(app);

            // to check header locally, use PowerShell command:
            // (invoke-webrequest https://localhost:7045/MeetingRoom).headers

            app.UseSerilogRequestLogging();
            Log.Debug("About to run...");

                app.UseHttpsRedirection();

            app.UseCors();

            
            app.UseAuthorization();

            // SignalR:
            //----------------------------------------------------------------------------------------
            //Signal R todo
            //app.MapHub<ChatHub>("/chathub");

            app.MapControllers();

            app.Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Unhandled exception");
            }
            finally
            {
                Log.Information("Shut down complete");
                Log.CloseAndFlush();
            }
        }

        private static void UseHeadersMiddleware(WebApplication app)
        {
            var headers = new Dictionary<string, string>() {
                {"X-Frame-Options", "DENY" },
                {"X-Xss-Protection", "1; mode=block"},
                {"X-Content-Type-Options", "nosniff"},
                {"Referrer-Policy", "no-referrer"},
                {"X-Permitted-Cross-Domain-Policies", "none"},
                {"Permissions-Policy", "accelerometer=(), camera=(), geolocation=(), gyroscope=(), magnetometer=(), microphone=(), payment=(), usb=()"},
                {"Content-Security-Policy", "default-src 'self'"}
            };
            // Middleware to control headers...
            app.Use(async (context, next) =>
            {
                foreach (var keyvalue in headers)
                {
                    if (!context.Response.Headers.ContainsKey(keyvalue.Key))
                    {
                        context.Response.Headers.Add(keyvalue.Key, keyvalue.Value);
                    }
                }
                await next(context);
            });
        }
    }
}