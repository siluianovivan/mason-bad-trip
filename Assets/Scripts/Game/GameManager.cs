using Game.Episodes;
using UnityEngine;

namespace Game
{
	public class GameManager : MonoBehaviour
	{
		[SerializeField] private AudioManager _audioManager;
		[SerializeField] private IntroTextController _introTextController;
		[SerializeField] private IntroFallEpisode _introFallEpisode;
	
		private void Start()
		{
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