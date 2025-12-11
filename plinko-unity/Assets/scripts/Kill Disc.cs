using UnityEngine;

public class KillDisc : MonoBehaviour
{
    //destroy object on collision
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(collider.gameObject);
    }
}
