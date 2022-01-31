using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    public float _speed;

    public float _limitY;




    // Start is called before the first frame update
    void Start()
    {

    }






    // Update is called once per frame
    void Update()
    {
        //
        transform.position=transform.position+Vector3.up * Time.deltaTime * _speed;


        float PositionY = transform.position.y;

        if (PositionY > _limitY || PositionY < -_limitY) 


        {
            Destroy(gameObject);




        }


    }
}

