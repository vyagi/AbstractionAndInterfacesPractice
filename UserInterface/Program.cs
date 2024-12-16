using Stationery;

//This file needs to compile and work. To achieve this you need to implement necessary changes in the Stationery.cs file in the Utilities project

var redCrayon = new Crayon(ConsoleColor.Red);

Console.WriteLine($"The red crayon is {(redCrayon.IsSharp ? "" : "not ")}sharp");
redCrayon.Sharpen();
Console.WriteLine($"The red crayon is {(redCrayon.IsSharp ? "" : "not ")}sharp");

var blueCrayon = new Crayon(ConsoleColor.Blue);
blueCrayon.Sharpen();

var pencil = new Pencil();
pencil.Sharpen();

var ballPen = new BallPen();
ballPen.Click();

var writableInstruments = new WritingInstrument[] { redCrayon, blueCrayon, pencil, ballPen };

StationeryTester.Write("Some text", writableInstruments);