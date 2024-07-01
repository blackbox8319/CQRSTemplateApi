using API.Installers.Extensions;
using API.Middlewares;
using Microsoft.AspNetCore.HttpOverrides;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.InstallServicesInAssembly(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExpectionHandlerMiddleware();
}
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthentication();
app.UseHttpsRedirection();

app.MapControllers();
app.UseStaticFiles();


app.UseRouting();
app.UseAuthorization();
app.UseCors("MyAllowSpecificOrigins");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
app.Run();
