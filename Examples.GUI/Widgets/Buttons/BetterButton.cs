using Examples.GUI.Commands.Abstraction;

namespace Examples.GUI.Widgets.Buttons
{
	public class BetterButton
	{
		private readonly ICommand command;

		public BetterButton(ICommand command)
		{
			this.command = command;
		}

		public void Click()
		{
			command.Execute();
		}
	}
}