using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour
{
    public GameObject explosion;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit detected");

        Destroy(other.gameObject);
        this.gameObject.SetActive(false);
    }
}

