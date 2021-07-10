using UnityEngine;

namespace Game.Episodes
{
	public class EpisodesController : MonoBehaviour
	{
		public const string EPISODE_NUMBER_SAVE_NAME = "Episode";

		[SerializeField] private Player _player;
		
		private EpisodeBase[] _episodes;

		private void Awake()
		{
			_episodes = GetComponentsInChildren<EpisodeBase>();
			
			for (var i = 0; i < _episodes.Length; i++)
			{
				_episodes[i].EpisodeCompleted += OnEpisodeCompleted;
			}
		}
		
		public bool TryToLoadSavedGame()
		{
			var lastCompletedEpisode = PlayerPrefs.GetInt(EpisodesController.EPISODE_NUMBER_SAVE_NAME, -1);

			if (lastCompletedEpisode == -1) return false;

			var positionToSpawnPlayer = Vector3.zero;
			for (var i = 0; i < _episodes.Length; i++)
			{
				if (_episodes[i].EpisodeNumber <= lastCompletedEpisode)
				{
					positionToSpawnPlayer = _episodes[i].GetPlayerSpawnerPosition();
					Destroy(_episodes[i].gameObject);
				}
			}

			_player.transform.position = positionToSpawnPlayer;
			_player.Activate();
			return true;
		}

		
		private void OnEpisodeCompleted(int episodeNumber)
		{
			PlayerPrefs.SetInt(EPISODE_NUMBER_SAVE_NAME, episodeNumber);
		}
	}
}