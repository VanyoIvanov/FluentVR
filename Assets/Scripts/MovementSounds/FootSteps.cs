using UnityEngine;
using UnityEngine.XR;

public class FootSteps : MonoBehaviour
{
    public AudioClip footstepSound;
    public float footstepInterval = 1f;
    public float movementThreshold = 0.01f;

    private AudioSource audioSource;
    private bool isPlaying = false;
    private float timer = 0.0f;
    private float lastMovementTime = 0.0f;
    private InputData _inputData;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        _inputData = GetComponent<InputData>();
    }

    void Update()
    {
        if (PlayerHasMoved())
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


    bool PlayerHasMoved()
    {
        // Check if the left joystick has been moved
        bool thumbstickMove;
        Vector2 thumbstickValue;

        if (_inputData._leftController.TryGetFeatureValue(CommonUsages.primary2DAxis, out thumbstickValue))
        {
            // Set a threshold value for joystick movement
            float joystickThreshold = 0.2f;

            // Check if the magnitude of the vector is greater than the threshold
            thumbstickMove = thumbstickValue.magnitude > joystickThreshold;
        }
        else
        {
            thumbstickMove = false; // Default to false if unable to get the feature value
        }

        bool keyboardMove = Input.GetButton("Vertical") || Input.GetButton("Horizontal");

        return keyboardMove || thumbstickMove;
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
