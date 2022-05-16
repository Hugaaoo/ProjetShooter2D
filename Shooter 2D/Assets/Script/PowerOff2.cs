using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerOff2 : MonoBehaviour
{
    public float Timer;
    Player Poweroff;
    public bool malusactif;


    private void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player");


            Poweroff = other.gameObject.GetComponent<Player>();
            if (Poweroff.malusactif)
            {
                Destroy(gameObject);

            }
            else
            {
                Poweroff.malusactif = true;


                {
                    Timer = 5;
                }
                malusactif = true;

                GetComponent<SpriteRenderer>().enabled = false;

                GetComponent<Rigidbody2D>().simulated = false;

            }

        }
    }
    private void Update()
    {
        if (malusactif == true)
        {
            if (Timer <= 0)
            {

                Poweroff.malusactif = (false);
                Destroy(gameObject);
            }

            Timer = Timer - Time.deltaTime;
        }
    }

}

