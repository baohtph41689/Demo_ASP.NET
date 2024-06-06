using Demo_ASP.NET.Models;
using Google.Protobuf.WellKnownTypes;

using Microsoft.EntityFrameworkCore;
using System.Collections.Specialized;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        // them cac dich vu cho cotainer
        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        //C.o.r.s public API 
        builder.Services.AddCors(Option => Option.AddDefaultPolicy(policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));
        // dang ki dich vu ket noi toi database
        builder.Services.AddDbContext<storeContext>(option =>
        {
            option.UseSqlServer(builder.Configuration.GetConnectionString("StringConection"));
        });
        //dki dv auto mapper
        builder.Services.AddAutoMapper(typeof(Program));
        var app = builder.Build();
        // Configure the HTTP request pipeline.
        //Cấu hình pipeline (chuoi cac Middleware ) xử lý yêu cầu HTTP()
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();// khi chay chay vo thang run() truoc tiep nhan cac http requet, yeu cau di qua 1 luong do la pipeline 
    }
}