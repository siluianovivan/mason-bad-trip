using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.Episodes
{
	public class EpisodeTrigger : MonoBehaviour
	{
		public event Action PlayerEnteredTheTrigger;
		private Animation anim;
		private bool _haveCollision;
		private bool _canChangeScene;
		private float _timeLeft = 1.5f;

		[SerializeField] private int _episodeNumber;
		[SerializeField] private GameObject _otherGameObject;

        private void Start()
        {
            anim = _otherGameObject.GetComponent<Animation>();
        }

        private void Update()
        {
            if (_haveCollision)
            {
				_timeLeft -= Time.deltaTime;
				if (_timeLeft < 0)
                {
					SceneManager.LoadScene(_episodeNumber);
					_haveCollision = false;
					_timeLeft = 1.5f;
				}
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
		{
			if (other.gameObject.CompareTag("PPlayer"))
			{
				_otherGameObject.SetActive(true);
				anim.Play();
				_haveCollision = true;
				PlayerEnteredTheTrigger?.Invoke();
			}
		}
	}
}