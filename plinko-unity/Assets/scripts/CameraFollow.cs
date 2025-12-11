using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //variables
    public Camera camera;
    public GameObject player;
    public GameObject disc;
    public float lerpRate = 0.5f;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetPosition;
        if (disc == null)
        {
            targetPosition = player.transform.position;
        }
        else
        { 
            targetPosition = disc.transform.position;
        }
        targetPosition.x = 0;
        targetPosition.z = camera.transform.position.z;

        // Assign camera posiotion part way from current to target positionn
        camera.transform.position = Vector3.Lerp(camera.transform.position, targetPosition, lerpRate);
    }

    public void FollowDisc(GameObject disc)
    {
        this.disc = disc;
    }
}
