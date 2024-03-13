namespace Sample01MVCWebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var builder = WebApplication.CreateBuilder(args);
            CreateHostBuilder(args).Build().Run();
            //var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");

            //app.Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
    }
}
