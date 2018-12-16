namespace GoogleVR.HelloVR
{
    using UnityEngine;
    using UnityEngine.EventSystems;

    public class Test : MonoBehaviour, VRInteractive
    {

        public void OnClickEnter()
        {
            GameManager.instance.player.SetPlayerDestination(this.transform.position);
        }
    }
}
