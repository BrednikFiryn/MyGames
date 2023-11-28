using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelletAll : MonoBehaviour
{
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
    }
}
