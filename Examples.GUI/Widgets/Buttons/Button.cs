namespace Examples.GUI.Widgets.Buttons
{
	public class Button
	{
		public EventHandler OnClicked { get; set; }

		public Button()
		{
			OnClicked += OnClicked;
		}

		private void Button_Clicked(object sender, EventArgs e)
		{

		}

		public void Click()
		{
			OnClicked(this, EventArgs.Empty);
		}
	}
}