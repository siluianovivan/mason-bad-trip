using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MainMenu
{
	public class Menu : MonoBehaviour
	{
		private const string GameSceneName = "Game";
		
		[SerializeField] private Button _createServerButton;
		[SerializeField] private Button _titlesButton;

		private void Start()
		{
			_createServerButton.onClick.AddListener(OnCreateServer);
			_titlesButton.onClick.AddListener(OnOpenTitles);
		}

		private void OnCreateServer()
		{
			SceneManager.LoadScene(GameSceneName);
		}

		private void OnOpenTitles()
		{
			//TODO: Add titles
		}
	}
}