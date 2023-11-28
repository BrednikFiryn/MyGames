using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointController : MonoBehaviour
{

    public GameObject point;
    public GameObject pointlast;
    public GameObject target;
    public AudioSource Audio1;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            Audio1.Play();
            point.SetActive(true);
            Destroy(pointlast, 0.5f);
            target.SetActive(false);
        }

    }
}

