using UnityEngine;

public class KillDisc : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(collider.gameObject);
    }
}
