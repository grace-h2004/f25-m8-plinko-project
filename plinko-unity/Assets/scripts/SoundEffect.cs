using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    //variables
    public AudioSource audioSource;
    public AudioClip audioClip;

    //play sound effect on collision of of objects
    private void OnTriggerEnter2D(Collider2D collider)
    {
        audioSource.PlayOneShot(audioClip);
    }
}
