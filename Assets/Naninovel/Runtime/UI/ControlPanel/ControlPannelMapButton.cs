namespace Naninovel.UI
{
	public class ControlPanelMapButton : ScriptableLabeledButton
	{
		private IUIManager uiManager;

		protected override void Awake ()
		{
			base.Awake();

			uiManager = Engine.GetService<IUIManager>();
		}

		protected override void OnButtonClick () => uiManager.GetUI<CustomUI>()?.Show();
	} 
}