using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gestion_interrupteur : MonoBehaviour
{
    // ON initialise : le bouton n'est pas activé
    [SerializeField] bool isactive = false;
    public GameObject porte;
    public float temp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        isactive = true;
        this.gameObject.transform.position += new Vector3(0,-temp, 0);
        porte.GetComponent<gestion_porte>().miseAJour(this.gameObject, isactive);
    }

    private void OnTriggerExit(Collider other)
    {
        isactive = false;
        this.gameObject.transform.position += new Vector3(0, temp, 0);
        porte.GetComponent<gestion_porte>().miseAJour(this.gameObject, isactive);
    }
}
