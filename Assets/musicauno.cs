using UnityEngine;

public class musicauno : MonoBehaviour
{
    [SerializeField] private AudioSource audiosource;
    [SerializeField] private AudioClip[] musicClips; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            int randomIndex = Random.Range(0, musicClips.Length);
            audiosource.clip = musicClips[randomIndex];
            audiosource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audiosource.Stop(); 
        }
    }
}
