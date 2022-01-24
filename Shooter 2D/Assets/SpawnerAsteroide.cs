using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnnemies : MonoBehaviour

 {
        
    public GameObject[] Animal;
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
            int randomAnimal = Random.Range(0, Animal.Length);

            float randomX = Random.Range(-10, 10);
            float randomZ = Random.Range(17, 19);

            Vector3 randomPosition = new Vector3(randomX, 0, randomZ);

            GameObject spawned = Instantiate(Animal[randomAnimal], randomPosition,
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
    

