
using UnityEngine.UI;
using UnityEngine;

public class EnemyCollect : MonoBehaviour
{
    public Text _textCount;
    public float _count;
    public float _CountMax;

    private void Start()
    {
        _CountMax = _count;
    }

    private void Update()
    {
        Score();
    }

    public void Score()
    {
        _textCount.text = "Осталось: " + _count.ToString();
    }

    public void CountCheck()
    {
        _count--;
        _CountMax = _count;
    }
}
