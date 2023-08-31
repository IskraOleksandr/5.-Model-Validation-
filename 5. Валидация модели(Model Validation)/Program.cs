using Microsoft.EntityFrameworkCore;
using _5._���������_������_Model_Validation_.Models;

var builder = WebApplication.CreateBuilder(args);

// �������� ������ ����������� �� ����� ������������
string? connection = builder.Configuration.GetConnectionString("DefaultConnection");

// ��������� �������� ApplicationContext � �������� ������� � ����������s_MVC_
builder.Services.AddDbContext<FilmContext>(options => options.UseSqlServer(connection));

// ��������� ������� MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseStaticFiles(); // ������������ ������� � ������ � ����� wwwroot s_MVCs_MVC_ControllerMVC

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Film}/{action=Index}/{id?}");

app.Run();
