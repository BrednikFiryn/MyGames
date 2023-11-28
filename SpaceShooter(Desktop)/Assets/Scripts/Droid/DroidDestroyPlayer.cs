
using UnityEngine;

public class DroidDestroyPlayer : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.tag == "Death")
        {
            Destroy(gameObject);
        }


    }
}
