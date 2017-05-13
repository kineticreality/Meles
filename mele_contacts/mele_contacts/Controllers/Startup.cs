public void ConfigureServices(IServiceCollection services)
{
    // Add framework services.
    services.AddMvc();

    var hostname = Environment.GetEnvironmentVariable("SQLSERVER_HOST") ?? "localhost";
    var password = Environment.GetEnvironmentVariable("SQLSERVER_SA_PASSWORD") ?? "Testing123";
    var connString = $"Data Source={hostname};Initial Catalog=KontenaAspnetCore;User ID=sa;Password={password};";

    services.AddDbContext<ApiContext>(options => options.UseSqlServer(connString));
}