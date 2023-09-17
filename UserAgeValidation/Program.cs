//rakendus küsib sugu  
//vastavalt valikust küsib usernamei 
//ss rakendus tervitab kasutajat   

using System.Net;

Console.WriteLine("Please, select your gender (m/f)");

char userGender = Char.Parse(Console.ReadLine()); //andemed sõne formaadis 

Console.WriteLine("Please, enter your last name:");

String userLastName = Console.ReadLine();

if (userGender == 'm') 
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}

else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms.{userLastName}!");
}

