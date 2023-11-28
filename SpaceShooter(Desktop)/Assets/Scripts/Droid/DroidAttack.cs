
using UnityEngine;

public class DroidAttack : MonoBehaviour
{
    public float Speed = 10;
    public DroidController droidController;
    private GameObject target;

    private void Start()
    {
        droidController = FindObjectOfType<DroidController>();
        target = GameObject.Find("Player");
    }

    void Update()
    {
        Attack();
    }

    public void Attack()
    {
        if (droidController._DroidLife != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Speed * Time.deltaTime);
            transform.LookAt(target.transform.position);
        }
    }
}
