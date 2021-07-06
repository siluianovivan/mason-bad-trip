using System.Collections;
using UnityEngine;
using UnityEngine.Playables;

namespace Game.Episodes
{
	public class IntroFallEpisode : MonoBehaviour
	{
		[SerializeField] private PlayableDirector _playableDirector;
		[SerializeField] private Player _player;
		
		public void PlayIntro()
		{
			_playableDirector.stopped += OnSceneCompleted;
			_playableDirector.Play();
		}

		private void OnSceneCompleted(PlayableDirector playableDirector)
		{
			_player.Activate();
		}
	}
}