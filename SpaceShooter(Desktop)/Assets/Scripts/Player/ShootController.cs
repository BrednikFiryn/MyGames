
using UnityEngine;

public class ShootController : MonoBehaviour
{

    [SerializeField] GameObject _Bullet;
    [SerializeField] Transform _shootPoint;

    public InterfaceController _interfaceController;


    private void Update()
    {
            ShootLogic();
    }

    private void ShootLogic()
    {
        if (Input.GetButtonDown("Fire1") && _interfaceController._GameStop == false)
        {
            OnAttack();
        }
    }

    private void OnAttack()
    {
        Instantiate(_Bullet, _shootPoint.position, transform.rotation);
    }

}
