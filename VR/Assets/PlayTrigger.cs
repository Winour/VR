using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayTrigger : MonoBehaviour, VRInteractive
{
    public void OnClickEnter()
    {
        SceneManager.LoadScene("Game");
    }
}
