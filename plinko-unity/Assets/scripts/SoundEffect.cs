using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        audioSource.PlayOneShot(audioClip);
    }
}
