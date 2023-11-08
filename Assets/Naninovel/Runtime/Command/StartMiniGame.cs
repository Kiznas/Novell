using Naninovel.UI;
using Naninovel.Runtime;
using DTT.MinigameMemory;
using UnityEngine;

namespace Naninovel.Commands
{
	[CommandAlias("miniGame")]
	public class StartMiniGame : Command
	{
		public override UniTask ExecuteAsync (AsyncToken asyncToken = default)
		{
			var service = Engine.GetService<MiniGameService>();
			service.StartGame(Engine.GetService<IUIManager>().GetUI<MiniGameUI>().GetComponent<MemoryGameManager>());
			return UniTask.CompletedTask;
		}
	}
}
