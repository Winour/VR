using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreathingIntensity : MonoBehaviour {

    public AudioSource audioSource;
	
	
    public void SetIntensity(float _intensity)
    {
        audioSource.pitch = _intensity;
    }

}
