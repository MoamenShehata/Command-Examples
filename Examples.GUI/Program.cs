// See https://aka.ms/new-console-template for more information
using Examples.GUI.Commands.Concrete;
using Examples.GUI.Widgets.Buttons;

Console.WriteLine("Hello, World!");
RunExample2();


void RunExample1()
{
	//Here we have a tollbar consists of 3 buttons
	//New window,Save,Undo
	var newWindowButton = new Button();
	newWindowButton.OnClicked += newWidnowButton_Cicked;
	var saveButton = new Button();
	saveButton.OnClicked += SaveButton_Cicked;
	var undoButton = new Button();
	undoButton.OnClicked += UndoButton_Cicked;



	//later user interacts with UI
	newWindowButton.Click();
	saveButton.Click();
	undoButton.Click();

	//Shortcuts
	while (true)
	{
		var shortCut = Console.ReadLine();
		switch (shortCut)
		{
			case "n":
				Console.WriteLine("new window is opened");
				break;

			case "s":
				Console.WriteLine("Saved successfully!");
				break;

			case "u":
				Console.WriteLine("Undo happened");
				break;
			case "exit":
				return;
		}
	}


	void newWidnowButton_Cicked(object sender, EventArgs args)
	{
		Console.WriteLine("new window is opened");
	}

	void SaveButton_Cicked(object sender, EventArgs args)
	{
		Console.WriteLine("Saved successfully!");
	}

	void UndoButton_Cicked(object sender, EventArgs args)
	{
		Console.WriteLine("Undo happened");
	}
}

void RunExample2()
{
	//Here we have a tollbar consists of 3 buttons
	//New window,Save,Undo
	var newWindowCommand = new NewWindowCommand();
	var saveCommand = new SaveCommand();
	var undoCommand = new UndoCommand();

	var newWindowButton = new BetterButton(newWindowCommand);
	var saveButton = new BetterButton(saveCommand);
	var undoButton = new BetterButton(undoCommand);

	//later user interacts with UI
	newWindowButton.Click();
	saveButton.Click();
	undoButton.Click();

	//Shortcuts
	while (true)
	{
		var shortCut = Console.ReadLine();
		switch (shortCut)
		{
			case "n":
				newWindowCommand.Execute();
				break;

			case "s":
				saveCommand.Execute();
				break;

			case "u":
				undoCommand.Execute();
				break;
			case "exit":
				return;
		}
	}


	void newWidnowButton_Cicked(object sender, EventArgs args)
	{
		Console.WriteLine("new window is opened");
	}

	void SaveButton_Cicked(object sender, EventArgs args)
	{
		Console.WriteLine("Saved successfully!");
	}

	void UndoButton_Cicked(object sender, EventArgs args)
	{
		Console.WriteLine("Undo happened");
	}
}