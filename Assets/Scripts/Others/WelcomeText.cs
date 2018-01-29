using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeText : MonoBehaviour {

	public GameObject well;
	public GameObject closeGate;
	public GameObject closeGate1;
	public GameObject Manager;
	//public GameObject ContainerImage;

	// Use this for initialization
	void Start () {

		well.gameObject.SetActive (false);
		//ContainerImage.gameObject.SetActive (false);
		Manager.gameObject.SetActive (false);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == ("Player")) 
		{
			well.gameObject.SetActive (true);
			closeGate.gameObject.GetComponent<Animation>().Play ("GraveYardGate");
			closeGate1.gameObject.GetComponent<Animation>().Play ("GraveYardGateRight");
			Manager.gameObject.SetActive (true);
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == ("Player")) 
		{
			well.gameObject.SetActive (false);
			//StartCoroutine(FindKey());
			StartCoroutine(CloseGates());

		}
	}
	IEnumerator CloseGates()
	{
		yield return new WaitForSeconds(4f);
		//ContainerImage.gameObject.SetActive (false);
		closeGate.gameObject.GetComponent<Animation>().Play ("CloseGates");
		closeGate1.gameObject.GetComponent<Animation>().Play ("CloseGatesRight");
	}

	IEnumerator FindKey()
	{
		yield return new WaitForSeconds(3f);
		//ContainerImage.gameObject.SetActive (true);
	}
}
