using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCameraTrigger : MonoBehaviour {

    private bool flag = true;

    private void Start()
    {
        flag = true;
    }

    void Update () 
	{
        if (this.GetComponent<Renderer>().isVisible && flag)
        {
            flag = false;
            // Do Smth
        }
	}
}
