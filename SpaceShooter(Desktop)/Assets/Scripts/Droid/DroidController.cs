
using UnityEngine;

public class DroidController : MonoBehaviour
{
    public GameObject _DroidLife, _DroidDeath;


    private void FixedUpdate()
    {
        DroidDestroy();
    }

    public void DroidDestroy()
    {
        if (_DroidLife == null)
        {
            _DroidDeath.SetActive(true);
            Destroy(gameObject, 1f);
        }
    }
}
