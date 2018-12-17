namespace GoogleVR.HelloVR
{
    using UnityEngine;
    using UnityEngine.EventSystems;

    public class MovePoint : MonoBehaviour, VRInteractive
    {

        public GameObject child;

        private void Update()
        {
            if (GameManager.instance.player.PlayerSqrDistanceFromPoint(this.transform.position) < 0.5f)
            {
                child.SetActive(false);
            }
            else
            {
                child.SetActive(true);
            }
        }

        public void OnClickEnter()
        {
            GameManager.instance.player.SetPlayerDestination(this.transform.position);
        }
    }
}
