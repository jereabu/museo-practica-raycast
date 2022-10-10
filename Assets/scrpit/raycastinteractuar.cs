using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class raycastinteractuar : MonoBehaviour
{
    public GameObject player;
    RaycastHit hit;
    public float distancia;
    public Text interactuar;
    
    // Update is called once per frame
    void Update()
    {
        Ray Rayo = new Ray(player.transform.position, Vector3.forward);
        Debug.DrawRay(transform.position, Vector3.forward * distancia);
        if (Physics.Raycast(Rayo, out hit, distancia)){
            if (hit.collider.tag == "atraccion")
            {
                interactuar.enabled = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    interactuar.enabled = false;
                }
            }
        }
    }
}
