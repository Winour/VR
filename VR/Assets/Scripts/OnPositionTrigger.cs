using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPositionTrigger : MonoBehaviour {

    private bool flag = true;
    [SerializeField]
    private GameObject[] objectToActivate;


    public BreathingIntensity bi;
    public float intensity;

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
            bi.SetIntensity(intensity);
        }
    }
}
