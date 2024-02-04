using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string meessage1 = "Krediler";
int trem = 12;
double amount = 100000.5;

//variables --> camelCase, 
bool isAuthenticated = true;

//condition
if (isAuthenticated)
{
	Console.WriteLine("Buton--> Hoşgeldin Berkay!");
}
else if (isAuthenticated == false)
{
	Console.WriteLine("Buton--> Giriş Yap!");
}

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" };
		//start     condition     //increment
for (int i = 0; i < loans.Length; i++)
{
	Console.WriteLine(loans[i]);
}

CourseManager courseManager = new();
Course[] courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)
{
	Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}
Console.WriteLine("Kod bitti!");