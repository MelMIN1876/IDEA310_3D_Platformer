using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class OpenMenu : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
