
using UnityEngine;

[System.Serializable]
public class Variable 
{
    public float xMin, xMax;
}

public class PlayerController : MonoBehaviour
{
    /// <summary>
    /// ѕоворот при помощи мыши
    /// </summary>
    private float _angleHorizontal;
    public float _SensitivityMouse = 5f;
    Quaternion _OriginalRotation;
    public Transform _player;
    
    /// <summary>
    /// движение коробл€ 
    /// </summary>
    [SerializeField] private float _Speed = 10;
    public Variable _variable;

    public PlayerDeath _playerDeath;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        _OriginalRotation = transform.rotation;
    }

    private void FixedUpdate()
    {
        if (_playerDeath._PlayerLife != null)
        {
            MoveLogic();
            RotationBody();
        }
    }

    /// <summary>
    /// движение коробл€ 
    /// </summary>    
    void MoveLogic()
    {
        float movement = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody>().velocity = new Vector3(movement, 0f, 0f) * _Speed;
        GetComponent<Rigidbody>().position = new Vector3(Mathf.Clamp(GetComponent<Rigidbody>().position.x, _variable.xMin, _variable.xMax), 0f);
    }

    /// <summary>
    /// ѕоворот при помощи мыши
    /// </summary>
    void RotationBody()
    {
        _angleHorizontal += Input.GetAxis("Mouse X") * _SensitivityMouse * Time.deltaTime;

        if (Mathf.Abs(_angleHorizontal) <= 90 && Mathf.Abs(_angleHorizontal) >= -90)
        {
            Quaternion rotationY = Quaternion.AngleAxis(_angleHorizontal, Vector3.up * Time.deltaTime);

            transform.rotation = _OriginalRotation * rotationY;
        }
    }
}
