using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class lvlMenuContoller : MonoBehaviour
{

    public int index;

    public void OnLvLMenuControll()
    {
        SceneManager.LoadScene(index);
    }

}
