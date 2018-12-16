using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;

    private Vector3 positionTarget, directionTarget, playerRealPos;

    private float verticalAngle;

	void Start () 
	{
        SetPlayerDestination(this.transform.position);
    }
	
	void Update () 
	{
        UpdatePlayerPosition();
	}

    public void SetPlayerDestination(Vector3 _newPosition)
    {
        positionTarget = _newPosition;
        positionTarget.y = 0.0f;
        SetPlayerRealPosition();
        directionTarget = positionTarget - this.transform.position;
        directionTarget.y = 0.0f;
        directionTarget.Normalize();
    }

    private void UpdatePlayerPosition()
    {
        SetPlayerRealPosition();

        if (Vector3.SqrMagnitude(positionTarget - playerRealPos) > 0.2f || (verticalAngle % Mathf.PI) > 0.6f)
        {
            verticalAngle += 6 * Time.deltaTime;
            this.transform.position = playerRealPos + new Vector3(0, (Mathf.Abs(Mathf.Sin(verticalAngle)) / 6) + 2, 0);
        }
        if (Vector3.SqrMagnitude(positionTarget - playerRealPos) < 0.2f)
        {
            return;
        }
        this.transform.Translate(directionTarget * speed * Time.deltaTime);       
    }

    private void SetPlayerRealPosition()
    {
        playerRealPos = this.transform.position;
        playerRealPos.y = 0;
    }
}
