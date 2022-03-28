using UnityEngine;

public class Destruction : MonoBehaviour


{
    public GameObject explosion;
    public string NombreEnnemies;


    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit detected");


        Destroy(other.gameObject);
        this.gameObject.SetActive(false);
        
    }
}



public class Powerup : MonoBehaviour { }