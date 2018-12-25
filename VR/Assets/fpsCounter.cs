using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class fpsCounter : MonoBehaviour {

    public Text fps;
	
	void Update () 
	{
        float a = Mathf.Clamp((1.0f / Time.deltaTime), 0, 60);
        fps.text = a.ToString("0.0");
	}
}
