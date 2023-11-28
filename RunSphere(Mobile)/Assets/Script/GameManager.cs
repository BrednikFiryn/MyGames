using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject lvlWin;
    public GameObject Wasted;
    public GameObject ProgressBar;
    public GameObject PLatform;

    public void OnButtonReload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void OnButtonBackMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void OnButtonPause()
    {
        Time.timeScale = 0;
    }

    public void OnButtonBack()
    {
        Time.timeScale = 1;
    }

}
