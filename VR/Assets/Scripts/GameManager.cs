using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleVR.HelloVR;

public class GameManager : MonoBehaviour {

    public PlayerController player;
    public MovePoint firstMovePoint;
    public static GameManager instance;

    [SerializeField]
    private GameObject[] objectsoToActivateDeactivate;

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

    private void Start()
    {
        firstMovePoint.OnClickEnter();
        firstMovePoint.UpdateObjectsToShow();
    }

    public void DeactivateGameObjects()
    {
        foreach( GameObject go in objectsoToActivateDeactivate)
        {
            go.SetActive(false);
        }
    }
	
	void Update () 
	{
		
	}
}
