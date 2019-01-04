using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCameraTrigger : MonoBehaviour {

    private bool flag = true;
    [SerializeField]
    private GameObject[] objectToActivate;

    public BreathingIntensity bi;
    public float intensity;

    private void Start()
    {
        flag = true;
    }

    void Update () 
	{
        if (this.GetComponent<Renderer>().isVisible && flag)
        {
            Vector3 origin = Camera.main.transform.position;
            Vector3 direction = this.transform.position - origin;
            Ray ray = new Ray(origin, direction);
            RaycastHit raycastHit = new RaycastHit();
            if(Physics.Raycast(ray, out raycastHit, 100))
            {
                if (raycastHit.transform.gameObject == this.gameObject)
                {
                    Vector3 a = Camera.main.WorldToViewportPoint(this.transform.position);
                    if (a.x > 0.2f && a.x < 0.8f && a.y > 0.15f && a.y < 0.85f && a.z > 0.0f)
                    {
                        flag = false;
                        foreach (GameObject o in objectToActivate)
                        {
                            o.SetActive(true);
                        }
                        bi.SetIntensity(intensity);
                    }
                }
            }
        }
	}
}
