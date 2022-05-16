using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tireennemies : MonoBehaviour


{
    // Start is called before the first frame update

    public float Timer;
    void Start()
    {
            Timer = Random.Range(2, 70);
    }


    public GameObject _projectile;


    // Update is called once per frame
    void Update()
    {

        if (Timer <= 0)
        {

            Instantiate(_projectile, transform.position, _projectile.transform.rotation);

            Timer = Random.Range(2, 7);
            
        }
        else
        {
            Timer = Timer - Time.deltaTime;
        }
    }

    }

