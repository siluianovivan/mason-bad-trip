using System;
using System.Collections;
using UnityEngine;

namespace Game.Episodes
{
	public class EpisodeBase : MonoBehaviour
	{
		public event Action EpisodeCompleted;
		
		[SerializeField] private float _destroyTime;
		[SerializeField] private GameObject _episodeObject;
		
		private void OnCollisionEnter2D(Collision2D collision)
		{
			if (collision.gameObject.CompareTag("PPlayer"))
			{
				StartCoroutine(SceneRoutine());
				
			}
		}

		protected virtual IEnumerator SceneRoutine()
		{
			_episodeObject.SetActive(true);
			
			yield return new WaitForSeconds(_destroyTime);
			
			Destroy(gameObject);
			
			EpisodeCompleted?.Invoke();
		}
	}
}