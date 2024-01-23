using System.Collections;
using TMPro;
using UnityEngine;
using OpenAI;

public class LetterByLetterAnimator : MonoBehaviour
{
    [SerializeField] private TextMeshPro textMeshPro;
    [SerializeField] private GameObject npc;
    [SerializeField] private float letterDelay = 0.05f;
    private Coroutine currentAnimation;
    private AIController aiController;

    private void Start()
    {
        if (textMeshPro == null)
        {
            textMeshPro = GetComponent<TextMeshPro>();
        }

        aiController = FindObjectOfType<AIController>();

        if (aiController == null)
        {
            Debug.LogError("AIController component not found. Make sure the script is attached to a GameObject with AIController.");
        }

        if (textMeshPro == null)
        {
            Debug.LogError("TextMeshProUGUI component not found. Make sure the script is attached to a GameObject with TextMeshProUGUI.");
        }
    }

    private void Update()
    {
        // Check if AIController and textMeshPro are present before starting the animation
        if (aiController != null && textMeshPro != null)
        {
            float distance = Vector3.Distance(aiController.player.position, npc.transform.position);
            Debug.LogWarning(distance);
            if (distance <= aiController.interactionDistance)
            {
                // Start the letter-by-letter animation if not already playing
                if (currentAnimation == null)
                {
                    currentAnimation = StartCoroutine(AnimateText());
                }
            }
            else
            {
                // Stop the animation if player is not within interaction distance
                if (currentAnimation != null)
                {
                    StopCoroutine(currentAnimation);
                    currentAnimation = null;
                }
            }
        }
    }

    private IEnumerator AnimateText()
    {
        Debug.LogWarning("hmmmm");
        string originalText = aiController.text;

        if (originalText != null)
        {
            textMeshPro.text = ""; // Clear the text

            foreach (char letter in originalText)
            {
                textMeshPro.text += letter;
                yield return new WaitForSeconds(letterDelay);
            }
        }
        else
        {
            Debug.LogError("Original text is null. Make sure there is initial text set on the TextMeshProUGUI component.");
        }
    }
}
