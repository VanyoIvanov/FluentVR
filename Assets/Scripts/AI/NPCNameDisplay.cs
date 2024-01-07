using TMPro;
using UnityEngine;

public class NPCNameDisplay : MonoBehaviour
{
    public TextMeshPro nameTextMesh;
    //public string npcName;

    void Start()
    {
        // Use the existing name of the NPC GameObject
        string npcName = gameObject.name;

        // Update the TextMesh Pro text
        if (nameTextMesh != null)
        {
            nameTextMesh.text = npcName;
        }
    }
}
