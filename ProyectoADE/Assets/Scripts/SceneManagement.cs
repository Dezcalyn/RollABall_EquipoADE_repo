using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void LoadScene (int sceneload)
    {
                SceneManager.LoadScene (sceneload);
    }

    public void ExitGame()
    {
        Debug.Log("Has cerrado el juego.");
        Application.Quit();
    }
}
