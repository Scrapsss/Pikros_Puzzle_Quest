using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hole_pikro : MonoBehaviour
{
    public GameObject Pikro_hole_destination;
    private bool hasTeleported = false;

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
        if (other.CompareTag("Pikro") && hasTeleported == false)
        {
            other.gameObject.SetActive(false);
            other.gameObject.transform.position = Pikro_hole_destination.transform.position;
            other.gameObject.SetActive(true);
            hasTeleported = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Pikro"))
        {
            hasTeleported = false;
        }
    }
}
