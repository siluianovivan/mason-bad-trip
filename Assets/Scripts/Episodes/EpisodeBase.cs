using UnityEngine;

namespace Episodes
{
	public class EpisodeBase : MonoBehaviour
	{
		[SerializeField] private float _destroyTime;
		[SerializeField] private GameObject _episodeObject;
		
		private void OnCollisionEnter2D(Collision2D collision)
		{
			if (collision.gameObject.CompareTag("PPlayer"))
			{
				_episodeObject.SetActive(true);
				Destroy(gameObject, _destroyTime);
			}
		}
	}
}