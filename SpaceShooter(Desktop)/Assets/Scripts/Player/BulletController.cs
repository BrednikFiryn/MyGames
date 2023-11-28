
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] GameObject _plasmashoot;
    [SerializeField] float _TimeToDestroyStart;
    private float _TimeToDestroy;
    public EnemyCollect _enemyCollect;

    private void Awake()
    {
        _enemyCollect = FindObjectOfType<EnemyCollect>();
        _TimeToDestroy = _TimeToDestroyStart;
    }

    private void FixedUpdate()
    {
            BulletLogic();
    }

    private void BulletLogic()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        PlasmaDestroy();
    }


    private void PlasmaDestroy()
    {
        if (_TimeToDestroy <= 0)
        {
            Destroy(gameObject);
        }

        _TimeToDestroy -= Time.deltaTime;
    }

    private void OnTriggerEnter(Collider collision)
    {
            if (collision.tag == "Bullet")
        {
            Destroy(gameObject);
        }
            if (collision.tag == "Object")
            {
            Destroy(collision.gameObject);
            _enemyCollect.CountCheck();
        }
    }
}
