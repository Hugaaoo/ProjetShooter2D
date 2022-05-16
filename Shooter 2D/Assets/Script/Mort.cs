using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Mort : MonoBehaviour
{
    internal static bool isPlayerDead;
    public GameObject explosion;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Asteroid"))
        {
            Destroy(gameObject);

            this.gameObject.SetActive(false);

            Debug.Log("hit detected");

            SceneManager.LoadScene("Menu");

            GameObject e = Instantiate(explosion) as GameObject;
            e.transform.position = transform.position;
        }


        if (other.gameObject.CompareTag("Tir"))
        {
            Destroy(gameObject);

            this.gameObject.SetActive(false);

            Debug.Log("hit detected");

            SceneManager.LoadScene("Menu");

            GameObject e = Instantiate(explosion) as GameObject;
            e.transform.position = transform.position;
        }


        

        
    }
   
}