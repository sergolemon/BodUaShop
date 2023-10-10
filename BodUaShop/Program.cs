using BodUaShop.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServices(builder.Configuration);

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.UseHsts();
}

app.UseStaticFiles();
app.UseRouting();

app.UseEndpoints(cfg => {
    cfg.MapControllerRoute("areas", "{area:exists}/{controller=home}/{action=index}");
    cfg.MapControllerRoute("default", "{controller=home}/{action=index}");
});

app.Run();
