using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;


public class victoire : MonoBehaviour
{

    public GameObject VictoryScreen;

    // Start is called before the first frame update
    void Start()
    {
        VictoryScreen.active = false; 
    
    }

    // Update is called once per frame
    void Update()
    {

        List<GameObject> ListAlien = GameObject.FindGameObjectsWithTag("Alien").ToList();

        if (ListAlien.Count == 0) 
        { 
            VictoryScreen.active = true;
            Time.timeScale = 0f;
        }
      
    }
}
