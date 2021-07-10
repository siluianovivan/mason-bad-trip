using Game.Episodes;
using UnityEngine;

namespace Game
{
	public class GameManager : MonoBehaviour
	{
		[SerializeField] private AudioManager _audioManager;
		[SerializeField] private IntroTextController _introTextController;
		[SerializeField] private IntroFallEpisode _introFallEpisode;
		[SerializeField] private EpisodesController _episodesController;
	
		private void Start()
		{
			if (_episodesController.TryToLoadSavedGame()) return;
			
			_introTextController.TextTypingCompleted += OnTextTypingCompleted;
			
			_audioManager.PlaySlavesSound();
			_introTextController.StartTyping();
		}

		private void OnTextTypingCompleted()
		{
			_introFallEpisode.PlayIntro();
		}
	}
}