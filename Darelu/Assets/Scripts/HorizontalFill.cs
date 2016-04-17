using UnityEngine;
using System.Collections;

public class HorizontalFill : MonoBehaviour {

	#region PRIVATE VARIABLES

	private Renderer myRenderer;

	#endregion

	void Start()
	{
		try
		{
			myRenderer = this.gameObject.transform.parent.GetComponent<Renderer> ();
		}catch(UnityException s)
		{
			Debug.Log ("Objeto sin Renderer, no funcionara el outlined");
		}

	}

	void OnEnable()
	{
		if(myRenderer != null)
			myRenderer.material.SetFloat ("_Outline", 0.0096f);
	}

	void OnDisable()
	{
		if(myRenderer != null)
			myRenderer.material.SetFloat ("_Outline", 0f);
	}
}
