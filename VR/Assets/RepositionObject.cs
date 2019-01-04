using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepositionObject : MonoBehaviour {

    public Vector3 position;
    public Transform objectTransform;

	void Start () 
	{
        objectTransform.localPosition = position;
        Destroy(this.gameObject);
	}

}
