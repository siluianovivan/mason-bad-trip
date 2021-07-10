using System;
using System.Collections;
using UnityEngine;

namespace Game.Episodes
{
	public class EpisodeBase : MonoBehaviour
	{
		public event Action<int> EpisodeCompleted;

		[SerializeField] private int _episodeNumber;
		[SerializeField] private float _destroyTime;
		[SerializeField] private GameObject _episodeObject;
		[SerializeField] private EpisodeTrigger _episodeTrigger;
		[SerializeField] private Transform _playerSpawnerAfterEpisodeCompleted;

		public int EpisodeNumber => _episodeNumber;
		
		private void Awake()
		{
			_episodeTrigger.PlayerEnteredTheTrigger += OnPlayerEnteredTheTrigger;
		}

		public Vector3 GetPlayerSpawnerPosition()
		{
			return _playerSpawnerAfterEpisodeCompleted.position;
		}

		private void OnPlayerEnteredTheTrigger()
		{
			StartCoroutine(SceneRoutine());
		}

		protected virtual IEnumerator SceneRoutine()
		{
			_episodeObject.SetActive(true);
			
			yield return new WaitForSeconds(_destroyTime);
			
			Destroy(gameObject);
			
			EpisodeCompleted?.Invoke(_episodeNumber);
		}
	}
}