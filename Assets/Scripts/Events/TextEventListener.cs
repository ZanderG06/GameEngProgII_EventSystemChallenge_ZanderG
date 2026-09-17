using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class TextEventListener : MonoBehaviour
{
    private TextMeshProUGUI text;
    private int timesPressed = 0;

    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    public void SpaceBarPressed(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            timesPressed++;
            text.text = $"You pressed space {timesPressed} time(s)";
        }
    }
}