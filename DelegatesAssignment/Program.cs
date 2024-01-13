// See https://aka.ms/new-console-template for more information
using DelegatesAssignment;

Console.WriteLine("Hello, World!");

PositivesManager positivesManager = new PositivesManager();

Positives userCase = UserInputHandler.GetUser();

positivesManager.AddPositives(userCase);

positivesManager.DisplayPositives();
