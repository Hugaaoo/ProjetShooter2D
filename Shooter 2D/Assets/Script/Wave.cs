using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public GameObject[] AlienType;
    public float SpaceColumns = 2f, SpaceRows = 2f;
    public int TotalAlienInLine = 6;

    void Awake()
    {
        // Generation de la vague d'alien

        for (int i = 0; i < AlienType.Length; i++) //boucle sur tous les elements du tableau
        {
            float posY = transform.position.y - (SpaceRows * i); //définition de la ligne (y)

            GameObject lineHolder = new GameObject("Row " + (i + 1));
            Ennemis ennemyHolder=lineHolder.AddComponent<Ennemis>();

            ennemyHolder.speed = 0.3f;

            for (int n = 0; n < TotalAlienInLine; n++) //boucle sur le nb d'alien à instancier
            {
                //definition de la position x de l'alien sur la ligne y.
                Vector2 posX = new Vector2(transform.position.x + SpaceColumns * n, posY);
                GameObject Go = Instantiate(AlienType[i].gameObject, posX, Quaternion.identity); //instantiation
                Go.transform.SetParent(lineHolder.transform); //Objet enfant de Wave
                Go.name = "Alien" + (n + 1) + "-row:" + (i + 1); //Définition du nom des aliens 
                Go.transform.rotation = transform.rotation;

            }
        }
    }
}