using EmqxHook.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseRouting();
#pragma warning disable ASP0014
app.UseEndpoints(endpoints =>
    endpoints.MapGrpcService<HookProviderService>()
);
#pragma warning restore ASP0014
app.Run();