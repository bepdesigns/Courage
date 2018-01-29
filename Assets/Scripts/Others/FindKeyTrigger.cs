using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindKeyTrigger : MonoBehaviour 

{

	public GameObject ContainerImage;


	void Start () {

		ContainerImage.gameObject.SetActive (false);

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == ("Player")) 
		{
			StartCoroutine(FindKey());
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == ("Player")) 
		{
			StartCoroutine(CloseGates());
			Destroy (this, 5);

		}
	}
	IEnumerator CloseGates()
	{
		yield return new WaitForSeconds (3f);
		ContainerImage.gameObject.SetActive (false);
	}

	IEnumerator FindKey()
	{
		yield return new WaitForSeconds(1f);
		ContainerImage.gameObject.SetActive (true);
	}
}
