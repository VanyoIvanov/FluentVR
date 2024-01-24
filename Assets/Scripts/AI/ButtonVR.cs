using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ButtonVR : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    public TextMesh textComponent;
    public NPCTextSuggestions.Character.CharacterType selectedCharacter;
    public GoogleCloudTTS GoogleCloudTTS;
    private GameObject presser;
    private bool isPressed;
    private int suggestionNum = 0;

    void Start()
    {
        isPressed = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
        {
            button.transform.localPosition = new Vector3(0, 0.003f, 0);
            presser = other.gameObject;
            onPress.Invoke();
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == presser)
        {
            button.transform.localPosition = new Vector3(0, 0.15f, 0);
            onRelease.Invoke();
            isPressed = false;
        }
    }

public void GiveSuggestion()
{
    var convStarters = NPCTextSuggestions.characterDictionary[selectedCharacter].conversationStarters[suggestionNum];

    textComponent.text = convStarters.mainText + "\n" + convStarters.translationText;
    GoogleCloudTTS.Synthesize(convStarters.mainText);
    suggestionNum += 1;
}

}
