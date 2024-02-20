using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using TMPro;

public class SuggestionHandler : MonoBehaviour
{
    public TMP_Text textComponent;
    public NPCTextSuggestions.Character.CharacterType selectedCharacter;
    public GoogleCloudTTS GoogleCloudTTS;
    public Transform player;
    private int suggestionNum = -1;
    public float interactionDistance = 3.0f;
    private InputData _inputData;

    private bool previousAButtonState = false;
    private bool previousBButtonState = false;

    private void Start()
    {
        _inputData = GetComponent<InputData>();
        textComponent = GetComponent<TMP_Text>();
    }

    private async void Update()
    {
        if (player != null)
        {
            float distance = Vector3.Distance(player.position, transform.position);

            if (distance <= interactionDistance)
            {
                _inputData._leftController.TryGetFeatureValue(CommonUsages.primaryButton, out bool Abutton);
                _inputData._leftController.TryGetFeatureValue(CommonUsages.secondaryButton, out bool Bbutton);

                // Check if the A button was pressed this frame and wasn't pressed in the previous frame
                if (Abutton && !previousAButtonState)
                {
                    GiveSuggestion();
                }

                // Check if the B button was pressed this frame and wasn't pressed in the previous frame
                if (Bbutton && !previousBButtonState)
                {
                    RepeatSuggestion();
                }

                // Update the previous button states for the next frame
                previousAButtonState = Abutton;
                previousBButtonState = Bbutton;
            }
        }
    }

    private void GiveSuggestion()
    {
        if (suggestionNum == -1) {
            suggestionNum = 0;
        }

        var convStarters = NPCTextSuggestions.characterDictionary[selectedCharacter].conversationStarters[suggestionNum];

        textComponent.text = convStarters.mainText + "\n" + "\n" + convStarters.translationText;

        GoogleCloudTTS.Synthesize(convStarters.mainText);

        if (suggestionNum < 9)
        {
            suggestionNum += 1;
        }
        else
        {
            suggestionNum = 0;
        }
    }

    private void RepeatSuggestion()
    {
        if (suggestionNum >= 0)
        {
        var convStarters = NPCTextSuggestions.characterDictionary[selectedCharacter].conversationStarters[suggestionNum-1];
        GoogleCloudTTS.Synthesize(convStarters.mainText);
        }
    }
}
