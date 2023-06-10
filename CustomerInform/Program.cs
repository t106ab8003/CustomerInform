using CustomerInformRepository;
using CustomerInformRepository.EFDbContext;
using CustomerInformService;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<CustomerInfoContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("CustomerInfo"));
});
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();//�P�@��request�N�ΦP�@�Ӫ���
builder.Services.AddScoped<ICustomerService, CustomerService>();//�P�@��request�N�ΦP�@�Ӫ���

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
