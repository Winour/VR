using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public PlayerController player;
    public static GameManager instance;

	void Awake () 
	{
        if (instance == null)
        {
            instance = this.GetComponent<GameManager>();
        }
        else
        {
            Destroy(this.gameObject);
        }
	}
	
	void Update () 
	{
		
	}
}
