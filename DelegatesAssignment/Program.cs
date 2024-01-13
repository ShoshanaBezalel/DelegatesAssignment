// See https://aka.ms/new-console-template for more information
using DelegatesAssignment;

Console.WriteLine("Hello, World!");

PositivesManager positivesManager = new PositivesManager();

for(int i = 0; i < 3; i++)
{
    Positives userCase = UserInputHandler.GetUser();
    positivesManager.AddPositives(userCase);
}

positivesManager.DisplayPositives();
