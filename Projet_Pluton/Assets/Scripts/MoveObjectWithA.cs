using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectWithA : MonoBehaviour
{
    public float moveSpeed = 5f; // Vitesse de déplacement de l'objet

    void Update()
    {
        // Vérifie si la touche A est enfoncée
        if (Input.GetKeyDown(KeyCode.A))
        {
            // Déplace l'objet en fonction de la touche appuyée
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
    }
}