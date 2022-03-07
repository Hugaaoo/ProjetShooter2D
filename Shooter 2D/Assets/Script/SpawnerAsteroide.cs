using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerAsteroide : MonoBehaviour

{

    public GameObject[] Asteroid;
    public float Timer;
    // Start is called before the first frame update
    void Start()
    {
        Timer = Random.Range(2, 7);
    }

    // Update is called once per frame
    void Update()
    {

        if (Timer <= 0)
        {
            int randomAsteroid = Random.Range(0, Asteroid.Length);

            float randomX = Random.Range(-9, 9);
            float randomZ = Random.Range(0, 0);

            Vector3 randomPosition = new Vector3(randomX, 8, randomZ);

            GameObject spawned = Instantiate(Asteroid[randomAsteroid], randomPosition,
                 Quaternion.Euler(transform.forward));

            spawned.transform.forward = transform.forward;

            Timer = Random.Range(2, 7);
        }
        else
        {
            Timer = Timer - Time.deltaTime;
        }
    }
}


