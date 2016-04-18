using UnityEngine;
using System.Collections;

public class InteractiveObject : MonoBehaviour {

	#region PUBLIC VARIABLES

	public string textToShow;

	public GameObject goToActivate;

	public GameObject goToDeactivate;

	#endregion

	#region PRIVATE VARIABLES

	private bool active = false;

	#endregion

	// Use this for initialization
	void Start () {
	
	}
	
	public void Activate()
	{
		DialogController.Instance.ShowText (textToShow);

		if (!active && goToActivate != null) {
			goToActivate.SetActive (true);
			goToDeactivate.SetActive (false);
			active = true;
		}

	}
		
}
