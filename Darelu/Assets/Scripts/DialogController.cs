using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogController : Singleton<DialogController> {

	#region PUBLIC VARIABLES

	public GameObject dialogBox;
	public Text dialogText;

	#endregion

	#region PRIVATE VARIABLES


	[SerializeField]
	private float timeToHide;

	[SerializeField]
	private float timePerLetter = 0.05f;

	#endregion

	// Use this for initialization
	void Start () {
		
	}

	/// <summary>
	/// Write the specified textToShow and timePerLet.
	/// </summary>
	/// <param name="textToShow">Text to show.</param>
	/// <param name="timePerLet">Time per letter to show.</param>
	public void ShowText(string textToShow, float timePerLet = 0f)
	{
		dialogBox.SetActive (true);
		StartCoroutine (WriteWorker (textToShow, timePerLet == 0f ? timePerLetter : timePerLet));
		
	}

	public IEnumerator WriteWorker(string textToShow, float time)
	{
		yield return new WaitForSeconds (0.2f);

		dialogText.text = "";
		int iterator = 0;

		foreach (char letter in textToShow) {
			dialogText.text += letter;
			yield return new WaitForSeconds (time);
		}

		yield return new WaitForSeconds (timeToHide);
		dialogText.text = "";
		dialogBox.SetActive (false);

		yield return null;
	}

	public void HideAll()
	{
		dialogText.text = "";
		dialogBox.SetActive (false);
	}


}
