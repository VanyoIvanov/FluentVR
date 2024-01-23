using System.Collections;
using TMPro;
using UnityEngine;

public class LetterByLetterAnimator : MonoBehaviour
{
    [SerializeField] private TextMeshPro textMeshPro;
    [SerializeField] private GameObject npc;
    [SerializeField] private float letterDelay = 0.1f;
    private Coroutine currentAnimation;

    private void Start()
    {
        if (textMeshPro == null)
        {
            textMeshPro = GetComponent<TextMeshPro>();
        }

        if (textMeshPro == null)
        {
            Debug.LogError("TextMeshProUGUI component not found. Make sure the script is attached to a GameObject with TextMeshProUGUI.");
        }
    }

    public void AnimateText(string originalText)
    {
        StartCoroutine(AnimateTextCoroutine(originalText));
    }

    private IEnumerator AnimateTextCoroutine(string originalText)
    {
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
