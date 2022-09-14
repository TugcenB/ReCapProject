using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Autofac;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddSingleton<IBrandDal, EfBrandDal>();
//builder.Services.AddSingleton<IBrandService,BrandManager>();

//builder.Services.AddSingleton<IColorDal, EfColorDal>();
//builder.Services.AddSingleton<IColorService,ColorManager>();

//builder.Services.AddSingleton<IUserDal,EfUserDal>();
//builder.Services.AddSingleton<IUserService,UserManager>();

//builder.Services.AddSingleton<ICustomerDal,EfCustomerDal>();
//builder.Services.AddSingleton<ICustomerService,CustomerManager>();

//builder.Services.AddSingleton<ICarDal,EfCarDal>();
//builder.Services.AddSingleton<ICarService,CarManager>();

//builder.Services.AddSingleton<IRentalDal,EfRentalDal>();
//builder.Services.AddSingleton<IRentalService,RentalManager>();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new AutofacBusinessModule()));

var app = builder.Build();

app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
