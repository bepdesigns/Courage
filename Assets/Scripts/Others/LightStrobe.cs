using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightStrobe : MonoBehaviour {

    Light testLight;

    public float minWaitTime;
    public float maxWaitTime;

    public float rotateSpeed;

	void Start () {

        testLight = GetComponent<Light>();
        StartCoroutine(Flashing());

	}

    void Update ()
    {
        //transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
    }
	
    IEnumerator Flashing ()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));
            testLight.enabled = !testLight.enabled;
        }  
    }
    
}
