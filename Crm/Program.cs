using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var ConnectionString=builder.Configuration.GetConnectionString("ErpConnection");
Console.WriteLine(ConnectionString);
builder.Services.AddDbContext<AppDbContext>(options=>options.UseMySql(ConnectionString,ServerVersion.AutoDetect(ConnectionString)));
var JwtOptions=builder.Configuration.GetSection("Jwt").Get<JwtOptions>();
builder.Services.AddAuthentication().AddJwtBearer(JwtBearerDefaults.AuthenticationScheme,options=>{
    options.SaveToken = true;
    options.TokenValidationParameters=new TokenValidationParameters{
        ValidateIssuer = true,
        ValidIssuer=JwtOptions?.Issuer,
        ValidateAudience=true,
        ValidAudience=JwtOptions?.Audience,
        ValidateIssuerSigningKey=true,
        IssuerSigningKey=new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtOptions?.SigningKey))
    };
});
builder.Services.AddSingleton(JwtOptions);


var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();


