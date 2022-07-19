using YaelNews.Contracts;
using YaelNews.DAL;
using YaelNews.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<YaelNewsContext>(options =>
{

});
builder.Services.AddScoped<IDataService, DataService>();
var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.Run();
