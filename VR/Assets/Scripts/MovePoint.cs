namespace GoogleVR.HelloVR
{
    using UnityEngine;
    using UnityEngine.EventSystems;

    public class MovePoint : MonoBehaviour, VRInteractive
    {

        public GameObject child;
        public GameObject[] objectsVisible;
        public bool farAway;

        private void Awake()
        {
            farAway = true;
        }

        private void Update()
        {
            if (GameManager.instance.player.PlayerSqrDistanceFromPoint(this.transform.position) < 0.5f)
            {
                if (farAway)
                {
                    child.SetActive(false);
                    farAway = false;
                    UpdateObjectsToShow();
                }
            }
            else
            {
                child.SetActive(true);
                farAway = true;
            }
        }

        public void OnClickEnter()
        {
            GameManager.instance.player.SetPlayerDestination(this.transform.position);
        }

        public void UpdateObjectsToShow()
        {
            GameManager.instance.DeactivateGameObjects();
            foreach (GameObject go in objectsVisible)
            {
                go.SetActive(true);
            }
        }
    }
}
