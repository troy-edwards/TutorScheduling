var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddControllers();
builder.Services.AddRazorPages();

var app = builder.Build();


// Configure the HTTP request pipeline.

app.UseBlazorFrameworkFiles();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("index.html");
app.UseStatusCodePagesWithRedirects("/errors/{0}");

app.Run();