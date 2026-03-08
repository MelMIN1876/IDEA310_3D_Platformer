using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("Stage_1");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
