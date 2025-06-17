using UnityEngine;

public class SoundZoneTrigger : MonoBehaviour
{
    public AudioClip zoneSound;  // Sound für diese Zone
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GameObject.Find("SoundManager").GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            audioSource.clip = zoneSound;
            audioSource.Play();
        }
    }
}
