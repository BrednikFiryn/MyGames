using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float Time1;
    public float MaxTime;
    private Text Text;
    public lvlController Lose;

    void Start()
    {
        Time1 = MaxTime;
        Text = GetComponent<Text>();
    }

    void Update()
    {
        Time1 -= Time.deltaTime;
        Text.text = "" + Time1;

        if (Time1 <= 0)
        {
            Lose.Menu();
        }

    }
}
