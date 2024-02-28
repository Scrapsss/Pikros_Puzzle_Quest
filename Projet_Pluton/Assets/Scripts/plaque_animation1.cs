using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plaque_animation : MonoBehaviour
{
    public GameObject bouton;
    public GameObject Porte;
    public Vector3 deplacementPorte;
    public Vector3 bouton_active;
    private bool active = false;
    private float speed = 1;
    private Vector3 position_depart;

     void Start() 
    {
        position_depart = Porte.transform.position;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (!active)
        {
            active = true;
            bouton.transform.position += bouton_active;
        }
    

    }


    void Update() 
    {
        if (active) 
        {
            if (Porte.transform.position != position_depart + deplacementPorte )
            {
                Porte.transform.position = Vector3.MoveTowards(Porte.transform.position, position_depart + deplacementPorte, speed * Time.deltaTime);
            }
        }
    }

}

