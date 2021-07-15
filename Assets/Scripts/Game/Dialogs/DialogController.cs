using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Dialogs
{
	public class DialogController : MonoBehaviour
	{
		[SerializeField] private Text _characterName;
		[SerializeField] private Text _dialogText;
		[SerializeField] private GameObject _dialogPanel;
		
		[SerializeField] private TextAsset _dialogTest;

		private void Start()
		{
			//StartDialog();
		}

		public void StartDialog()
		{
			_dialogPanel.SetActive(true);
			
			var dialogData = JsonUtility.FromJson<DialogData>(_dialogTest.text);
			StartCoroutine(DialogRoutine(dialogData));

		}

		private IEnumerator DialogRoutine(DialogData dialogData)
		{
			for (var i = 0; i < dialogData.Dialog.Length; i++)
			{
				_characterName.text = dialogData.Dialog[i].Name;

				for (var j = 0; j < dialogData.Dialog[i].Lines.Length; j++)
				{
					_dialogText.text = dialogData.Dialog[i].Lines[j];
					yield return new WaitForSeconds(0.5f);
					yield return new WaitWhile(() => !Input.GetKeyDown(KeyCode.Space));
				}
			}
			
			_dialogPanel.SetActive(false);
		}
	}
}