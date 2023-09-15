

//game
List<string> greatGames = new List<string> { "Spider-man(PS4)", "Spider-man 2 (PS5)", "Spiderman VR (2023) ((made by me))", "Hentai Hitler" };
//array thing
List<string> badGames = new List<string> { "Smash", "Any Mortal Combat Game", "Overwatch 2", "MW2" };
//foreach loops :D
foreach (string game in greatGames)
{
    Console.WriteLine(greatGames);
}
//Prints num of great games
Console.WriteLine(greatGames.Count);
//Add a range 
greatGames.AddRange(badGames);
//Print it console 
Console.WriteLine(greatGames.Count);
//If the list contains 
if (greatGames.Contains("Spider-Man (PS4)"))
{
    Console.WriteLine("ima put some dirt in your eye.");
}
//Else, add Apex to the games list.
else
{
    greatGames.Add("Apex");
}
//make an int and assign it the value of 6.
int num = 6;
//If the int value is less than the number of games in the games list, then remove the game at index 6 of the games list.
if (greatGames.Count >= num)
{
    greatGames.RemoveRange(num, 1);
}
//Else, print game not found!.
else
{
    Console.WriteLine("Game not found re re.");
}
//Print to console, "All games in the list:"
Console.WriteLine("\n all of da games in the list:");
//Loop through the games list and print each game to console again.
foreach (string game in greatGames)
{
    Console.WriteLine($"{game}");
}
//Sort the games list.
greatGames.Sort();
//Print to console, "Sorted Games List:".
Console.WriteLine("\n Sorted Games List:");
//Print each game to console.
foreach (string game in greatGames)
{
    Console.WriteLine($"{game}");
}
//Create a string array
string[] list = new string[greatGames.Count];
//Copy the games list
greatGames.CopyTo(list, 0);
//Clear
greatGames.Clear();
Console.WriteLine("\n");
//Print each of the strings in the list.
foreach (string game in list)
{
    Console.WriteLine(greatGames);
}