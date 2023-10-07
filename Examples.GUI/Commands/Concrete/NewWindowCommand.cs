using Examples.GUI.Commands.Abstraction;

namespace Examples.GUI.Commands.Concrete
{
	public class NewWindowCommand : ICommand
	{
		public void Execute()
		{
			Console.WriteLine("new window is opened");
		}
	}

	public class SaveCommand : ICommand
	{
		public void Execute()
		{
			Console.WriteLine("Saved successfully!");
		}
	}

	public class UndoCommand : ICommand
	{
		public void Execute()
		{
			Console.WriteLine("Undo happened");
		}
	}


}