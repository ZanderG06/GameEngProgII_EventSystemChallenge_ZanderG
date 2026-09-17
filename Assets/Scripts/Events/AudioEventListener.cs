using UnityEngine;
using UnityEngine.InputSystem;

public class AudioEventListener : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void SpaceBarPressed(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            audioSource.Play();
        }
    }
}