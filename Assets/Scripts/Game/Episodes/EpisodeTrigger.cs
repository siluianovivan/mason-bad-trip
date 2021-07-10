using System;
using UnityEngine;

namespace Game.Episodes
{
	public class EpisodeTrigger : MonoBehaviour
	{
		public event Action PlayerEnteredTheTrigger;

		[SerializeField] private int _episodeNumber;
		
		private void OnTriggerEnter2D(Collider2D other)
		{
			if (other.gameObject.CompareTag("PPlayer"))
			{
				PlayerEnteredTheTrigger?.Invoke();
			}
		}
	}
}