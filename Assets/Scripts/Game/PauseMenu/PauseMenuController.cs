using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Game.PauseMenu
{
	public class PauseMenuController : MonoBehaviour
	{
		[SerializeField] private Button _pauseButton;
		[SerializeField] private Button _continueButton;
		[SerializeField] private Button _exitButton;

		[SerializeField] private GameObject _menuPanel;

		private void Awake()
		{
			_pauseButton.onClick.AddListener(OnPauseClicked);
			_continueButton.onClick.AddListener(OnContinueClicked);
			_exitButton.onClick.AddListener(OnExitClicked);
		}

		private void OnPauseClicked()
		{
			_pauseButton.gameObject.SetActive(false);
			_menuPanel.SetActive(true);
		}
		
		private void OnContinueClicked()
		{
			_pauseButton.gameObject.SetActive(true);
			_menuPanel.SetActive(false);
		}

		private void OnExitClicked()
		{
			SceneManager.LoadScene("Menu");
		}
	}
}