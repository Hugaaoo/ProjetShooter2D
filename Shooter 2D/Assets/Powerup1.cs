using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Powerup1 : MonoBehaviour
{

    public float Timer;
    Player Powerupon;
    public bool actifpowerup; 


    private void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player");

            
            Powerupon = other.gameObject.GetComponent<Player>();
            if (Powerupon.powerupactif)
            { 
                Destroy(gameObject); 
            
            }
            else 
            { 
                Powerupon.powerupactif = true;
          

                {
                    Timer = 5 ;
                }
                actifpowerup = true ; 
            
                GetComponent<SpriteRenderer>().enabled = false;

                GetComponent<Rigidbody2D>().simulated = false;

            }

        }
    }
    private void Update()
    {
        if ( actifpowerup == true )
        { 
        if (Timer <= 0)
        {

            Powerupon.powerupactif = (false);
            Destroy(gameObject);
        }

        Timer = Timer - Time.deltaTime;
        }
    }

}
    
