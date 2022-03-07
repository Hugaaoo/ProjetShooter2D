using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float _speed;

    public float _rangeHorizontal;

    public GameObject _projectile;





    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * _speed);

        float positionX = transform.position.x;

        positionX = Mathf.Clamp(positionX, -_rangeHorizontal, _rangeHorizontal);

        transform.position = new Vector3(positionX, transform.position.y, transform.position.z);


        if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(_projectile, transform.position, _projectile.transform.rotation);


        }





    }
}

