using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPositionTrigger : MonoBehaviour {

    private bool flag = true;
    [SerializeField]
    private GameObject[] objectToActivate;

    private void Start()
    {
        flag = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(flag && other.transform.CompareTag("Player"))
        {
            foreach (GameObject o in objectToActivate)
            {
                o.SetActive(true);
            }
        }
    }
}
