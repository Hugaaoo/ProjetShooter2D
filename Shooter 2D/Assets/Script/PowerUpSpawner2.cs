using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner2 : MonoBehaviour

{
    public GameObject Powerup;
    public GameObject Powerup2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDestroy()
    {
        int chance = Random.Range(-500, 500);

        if (chance < 100)
        {
            Instantiate(Powerup, transform.position, Powerup.transform.rotation);



        }
        else if (chance < -100) { }

    
    
    
        int chance2 = Random.Range(-500, 500);

        if (chance2 < -300)
        {
            Instantiate(Powerup2, transform.position, Powerup.transform.rotation);



        }
        else if (chance2 < 300) { }
    }
}
