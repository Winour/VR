using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterOneAnimation : MonoBehaviour {

    public float distance, speed;

	void Start () 
	{
		
	}
	
	void Update () 
	{
		if(distance > 0.0f)
        {
            distance -= speed * Time.deltaTime;
            this.transform.Translate(-this.transform.forward * speed * Time.deltaTime, Space.World);
        }
	}
}
