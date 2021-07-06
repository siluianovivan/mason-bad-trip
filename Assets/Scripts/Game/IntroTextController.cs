using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
	public class IntroTextController : MonoBehaviour
	{
		public event Action TextTypingCompleted;
		
		[SerializeField] private Text _text;
		[SerializeField] private AudioSource _typingSound;
		[SerializeField] private float _delayBetweenLetters;
		[SerializeField] private float _delayAfterTypingCompleted;
		
		private string _textToType;

		public void StartTyping()
		{
			_textToType = _text.text;
			_text.text = string.Empty;
			
			gameObject.SetActive(true);
			StartCoroutine(TypeCoroutine());
		}

		private IEnumerator TypeCoroutine()
		{
			_typingSound.Play();
			
			for (var i = 0; i < _textToType.Length; i++)
			{
				_text.text = _textToType.Substring(0, i+1);
				yield return new WaitForSeconds(_delayBetweenLetters);
			}
			
			yield return new WaitForSeconds(_delayAfterTypingCompleted);
			
			gameObject.SetActive(false);
			
			TextTypingCompleted?.Invoke();
		}
	}
}