// See https://aka.ms/new-console-template for more information

//Created a new list 'games' containing popular game titles.
List<string> games = new List<string>
{
    "CS:GO",
    "Halo 3",
    "Borderland 3",
    "Fifa 22",
    "Minecraft"
};

//Initialized an array 'otherGames' with additional game titles.
string[] otherGames = new string[]
{
    "Tiny TinaWonderlands",
    "Farcry 3",
};

//Printed each game title in the 'games' list using a foreach loop.
foreach (string game in games)
{
    Console.WriteLine(game);
}

//Displayed the total number of games in the list.
Console.WriteLine($"\nGames in list: {games.Count}");

//Added additional games from the 'otherGames' array to the 'games' list.
games.AddRange(otherGames);

//Displayed the updated count of games in the list after the addition.
Console.WriteLine($"\nGame in list: {games.Count}");

//Checked if the 'Halo' game is present in the 'games' list. If found, a message is printed. Otherwise, 'Halo' is added to the list.
if (games.Contains("Halo"))
{
    Console.WriteLine("\nMASTER CHEIF is in the house!!");
}
else
{
    games.Add("Halo");
}

//Defined an integer 'myInt' with a value of 6.
int myInt = 6;

//Checked if 'myInt' is less than the count of games in the list. If true, an item is removed from the list at the index 'myInt.' Otherwise, a message is displayed indicating that the game was not found.
if (myInt < games.Count)
{
    games.RemoveAt(myInt);
}
else
{
    Console.WriteLine("\nGame not found!");
}

// Printed all the game titles in the 'games' list using a foreach loop, providing a comprehensive list of all games.
Console.WriteLine("\nAll games in the list:");
foreach(string game in games)
{
    Console.WriteLine(game);
}

//Sorted the 'games' list in alphabetical order.
games.Sort();

//Displayed the sorted game list to reflect the updated order of games.
Console.WriteLine("\nSorted games list:");
foreach(string game in games)
{
    Console.WriteLine(game);
}

//Created a new string array 'newList' with the same size as the 'games' list.
string[] newList = new string[games.Count];

//Copied the elements from the 'games' list to 'newList.'
games.CopyTo(newList);

//Cleared the original 'games' list to remove its contents.
games.Clear();

//Displayed the contents of the 'newList,' which now holds the copied elements.
Console.WriteLine("\nNew list:");
foreach(string game in newList)
{
    Console.WriteLine(game);
}