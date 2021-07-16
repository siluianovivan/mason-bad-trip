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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
				_otherGameObject.SetActive(true);
=======
>>>>>>> parent of 3087dae (Add a animation between scenes.)
				anim.Play();
				_haveCollision = true;
=======
>>>>>>> parent of afea41f (Add a transition between episodes.)
=======
>>>>>>> parent of afea41f (Add a transition between episodes.)
				PlayerEnteredTheTrigger?.Invoke();
			}
		}
	}
}