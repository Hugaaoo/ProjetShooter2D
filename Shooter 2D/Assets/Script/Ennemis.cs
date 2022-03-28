using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ennemis : MonoBehaviour
{
	public float _speed;

	public float _rangeHorizontal;

	private Transform enemyHolder;
	public float speed;

	public GameObject shot;
	
	public float fireRate = 0.997f;

	// Use this for initialization
	void Start()
	{
		Debug.Log("start");
		InvokeRepeating("MoveEnemy", 0.1f, 0.3f);
		enemyHolder = GetComponent<Transform>();
	}

	void MoveEnemy()
	{
		enemyHolder.position += Vector3.right * speed;

		foreach (Transform enemy in enemyHolder)
		{
			if (enemy.position.x < -10.5f || enemy.position.x > 10.5f)
			{
				Debug.Log("coucou");
				speed = -speed;
				enemyHolder.position += Vector3.down * 0.5f;
				return;
			}

			//EnemyBulletController called too?
			//if (Random.value > fireRate)
			//{
			//	Instantiate(shot, enemy.position, enemy.rotation);
			//}


			if (enemy.position.y <= -4)
			{
				Mort.isPlayerDead = true;
				Time.timeScale = 0;
			}
		}

		if (enemyHolder.childCount == 1)
		{
			CancelInvoke();
			InvokeRepeating("MoveEnemy", 0.1f, 0.25f);
		}

		if (enemyHolder.childCount == 0)
		{
			float horizontalInput = Input.GetAxis("Horizontal");

			transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * _speed);

			float positionX = transform.position.x;

			positionX = Mathf.Clamp(positionX, -_rangeHorizontal, _rangeHorizontal);

			transform.position = new Vector3(positionX, transform.position.y, transform.position.z);
		}
	}
}
