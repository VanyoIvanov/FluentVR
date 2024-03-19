using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMenuController : MonoBehaviour
{
    public TMP_Dropdown worldOpts;
    private readonly string[] scenes;

    public GameMenuController()
    {
        scenes = new string[] { "EnglishScene", "SpanishScene", "EscapeRoom", "QuizGame", "ShipCaptain" };
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(scenes[worldOpts.value]);
    }
}
