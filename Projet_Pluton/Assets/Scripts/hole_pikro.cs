using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hole_pikro : MonoBehaviour
{
    public GameObject Pikro_hole_destination;
    private bool hasTeleported;

    // Start is called before the first frame update
    void Start()
    {
        hasTeleported = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player") && !hasTeleported)
        {
            hasTeleported = true;
            other.gameObject.SetActive(false);
            other.gameObject.transform.position = Pikro_hole_destination.transform.position;
            other.gameObject.SetActive(true);
            Debug.Log(hasTeleported);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && hasTeleported)
        {
            hasTeleported = false;
            Debug.Log(hasTeleported);
        }
    }
}
