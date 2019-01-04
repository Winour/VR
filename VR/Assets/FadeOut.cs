using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour {

    public Image black;
    private float ammount = -0.2f;
    private Color initialColor;

    private void Start()
    {
        initialColor = black.color;
    }

    void Update () 
	{
		if(ammount > 1.0f)
        {
            Destroy(this.gameObject);
        }
        ammount += Time.deltaTime * 0.4f;
        black.color = new Color(initialColor.r, initialColor.g, initialColor.b, 1 - ammount);
	}
}
