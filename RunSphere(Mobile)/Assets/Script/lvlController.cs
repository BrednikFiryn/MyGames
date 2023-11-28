using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lvlController : MonoBehaviour
{

    public GameObject Winlvl;
    public GameObject Platform;
    public GameObject Lvl1Title;
    public AudioSource Audio2;
    public GameObject TextTimer;
    public GameObject Lose;

    private void Awake()
    {
        Winlvl.SetActive(false);
    }

    public void Menu()
    {
            Lose.SetActive(true);
            Platform.SetActive(false);
            Lvl1Title.SetActive(false);
            TextTimer.SetActive(false);
            Audio2.Stop();
     }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Finish"))
        {
            Menu();
            Winlvl.SetActive(true);
            UnLockLevel();
        }

        if (other.CompareTag("Death"))
        {
            Menu();
            Lose.SetActive(true);
        }
    }

    public void UnLockLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("levels"))
        {
            PlayerPrefs.SetInt("levels", currentLevel + 1);
        }
    }

}
