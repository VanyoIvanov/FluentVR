using UnityEngine;

public class FootSteps : MonoBehaviour
{
    public AudioClip footstepSound;
    public float footstepInterval = 1f;
    public float movementThreshold = 0.01f;

    private AudioSource audioSource;
    private bool isPlaying = false;
    private float timer = 0.0f;
    private float lastMovementTime = 0.0f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetButton("Vertical") || Input.GetButton("Horizontal"))
        {
            if (!isPlaying || Time.time > lastMovementTime + footstepInterval)
            {
                timer = 0.0f;
                isPlaying = true;
                PlayFootstepSound();
                lastMovementTime = Time.time;
            }
        }
        else
        {
            if (isPlaying)
            {
                timer = 0.0f;
                isPlaying = false;
                audioSource.Stop();
            }
        }
    }

    void PlayFootstepSound()
    {
        if (timer == 0.0f || Time.time > lastMovementTime + movementThreshold)
        {
            timer = footstepInterval;
            audioSource.PlayOneShot(footstepSound);
        }
    }
}
