using Game.Episodes;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MainMenu
{
	public class Menu : MonoBehaviour
	{
		private const string GameSceneName = "Game";
		
		[SerializeField] private Button _startNewGameButton;
		[SerializeField] private Button _continueButton;
		[SerializeField] private Button _settingsButton;
		[SerializeField] private Button _titlesButton;

		private void Start()
		{
			_startNewGameButton.onClick.AddListener(OnStartNewGame);
			_continueButton.onClick.AddListener(OnContinue);
			_settingsButton.onClick.AddListener(OnSettings);
			_titlesButton.onClick.AddListener(OnOpenTitles);

			if (IsAnySavesExist())
			{
				_continueButton.gameObject.SetActive(true);
			}
			else
			{
				_continueButton.gameObject.SetActive(false);
			}
		}

		private void OnStartNewGame()
		{
			PlayerPrefs.DeleteAll();
			OnContinue();
		}

		private void OnContinue()
		{
			SceneManager.LoadScene(GameSceneName);
		}

		private void OnSettings()
		{
			//TODO: Add settings
		}

		private void OnOpenTitles()
		{
			//TODO: Add titles
		}

		private bool IsAnySavesExist()
		{
			var defaultValue = -1;
			var lastCompletedLevel = PlayerPrefs.GetInt(EpisodesController.EPISODE_NUMBER_SAVE_NAME, defaultValue);

			return lastCompletedLevel != defaultValue;
		}
	}
}