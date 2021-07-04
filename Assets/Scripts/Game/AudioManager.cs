using UnityEngine;

namespace Game
{
	public class AudioManager : MonoBehaviour
	{
		[SerializeField] private AudioSource _slavesSounds;

		public void PlaySlavesSound()
		{
			_slavesSounds.Play();
		}
	}
}