using MetaMusic.Integrations;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddEndpointsApiExplorer()
    .AddControllers();

builder.Services
    .AddSwaggerGen();

builder.Services
    .AddMappings()
    .AddFacades();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    builder.AddJsonConfig("Development");
}
else
{
    builder.AddJsonConfig();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();