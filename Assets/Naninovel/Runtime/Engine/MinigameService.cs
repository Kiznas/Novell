using DTT.MinigameMemory;
using Naninovel.Parsing;
using Naninovel.UI;
using UnityEngine;

namespace Naninovel.Runtime
{
	[InitializeAtRuntime(initializationPriority: 9999)]
	public class MiniGameService : IEngineService
	{
		private MemoryGameSettings _newGameSettings;

		public MiniGameService ()
		{
		}

		public UniTask InitializeServiceAsync ()
		{
			_newGameSettings = Resources.Load<MemoryGameSettings>("Settings");
			return UniTask.CompletedTask;
		}

		public void StartGame(MemoryGameManager newManager)
		{
			newManager.StartGame(_newGameSettings);
			newManager.Finish += MemoryGameWin;
		}

		private void MemoryGameWin(MemoryGameResults obj)
		{
			Engine.GetService<IUIManager>().GetUI<MiniGameUI>().Hide();
		}
		public void ResetService ()
		{
			// Reset service state here.
		}

		public void DestroyService ()
		{
			// Stop the service and release any used resources here.
		}
	}
}