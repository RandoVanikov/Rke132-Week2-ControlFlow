//küsin kasutaja vanust
//kui vanus väiksem kui 13 siis konsoolis "You are too young for Instagram!"
// else  "Welcome to Instagram!"
//note for self: int ... Int32.Parse for numbers; string ... console.writeline for words

Console.WriteLine("Ender your age:");
string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean true/false
bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

if (isAgeNumber == true)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram!");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram!");
    }
}
else 
{
    Console.WriteLine("Could not read your age!"); 
}

//int userAge = Int32.Parse (Console.ReadLine()); //"13" - heap, 13 - stack
//if (userAge >= 13)
//{
//    Console.WriteLine("Welcome to Instagram!");
//}
//else
//{
//    Console.WriteLine("You are too young to use Instagram!");
//}

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");