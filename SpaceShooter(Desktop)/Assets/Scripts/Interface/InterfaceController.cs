using UnityEngine.SceneManagement;
using UnityEngine;

public class InterfaceController : MonoBehaviour
{
    public GameObject[] _GamePanel;
    public bool _GameStop;

    public PlayerDeath _playerDeath;
    public EnemyCollect _enemyCollect;


    private void Start()
    {
        _GameStop = false;
        foreach (GameObject GamePanels in _GamePanel) ;
        Time.timeScale = 1;
        _enemyCollect = FindObjectOfType<EnemyCollect>();
        _playerDeath = FindObjectOfType<PlayerDeath>();
    }

    private void Update()
    {
        PauseMenu();
        LifeCheck();
        VictoryMenu();
    }

    public void PauseMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && _GameStop == false)
            {
                Cursor.lockState = CursorLockMode.Confined;
            _GamePanel[0].SetActive(false);
            _GamePanel[1].SetActive(true);
            _GameStop = true;
                Time.timeScale = 0;
            }
    }    

    public void OnClickBack()
    {
        _GameStop = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
    }

    public void OnClickRestart()
    {
        SceneManager.LoadScene(0);
    }

    public void LoseMenu()
    {
        _GamePanel[2].SetActive(true);
        PanelControll();
    }

    private void LifeCheck()
    {
        if (_playerDeath._PlayerLife == null)
        {
            LoseMenu();
            Time.timeScale = 0;
        }
    }

    private void VictoryMenu()
    {
       if(_enemyCollect._CountMax <= 0)
        {
            _GamePanel[3].SetActive(true);
            PanelControll();
            Time.timeScale = 0;
        }
    }

    private void PanelControll()
    {
        _GamePanel[0].SetActive(false);
        Cursor.lockState = CursorLockMode.Confined;
        Destroy(_GamePanel[1]);
    }

}
