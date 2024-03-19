using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;

public class GameMenuManager : MonoBehaviour
{
    public Transform head;
    public float spawnDistance = 1;
    public GameObject menu;
    private InputData _inputData;

    private void Start()
    {
        _inputData = GetComponent<InputData>();
    }

    void Update()
    {
        _inputData._leftController.TryGetFeatureValue(CommonUsages.menuButton, out bool MenuButton);
        if (MenuButton == true)
        {
            menu.SetActive(!menu.activeSelf);

            menu.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
        }

        menu.transform.LookAt(new Vector3(head.position.x, menu.transform.position.y, head.transform.position.z));
        menu.transform.forward *= -1;
    }
}
