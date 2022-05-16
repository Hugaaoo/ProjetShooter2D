using UnityEngine;

public class Destruction : MonoBehaviour


{
    public GameObject explosion;
 
   


    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit detected");

        EnemyController hit = other.gameObject.GetComponent<EnemyController>();
        if(hit == null)
        {
            Destroy(other.gameObject);
            
        }
        else
        {
            hit.Hit();
        }
         

      
        this.gameObject.SetActive(false);


        
           
        
        
        
    }
}



