using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveHolo : MonoBehaviour
{
    public GameObject hologram = null;
    public GameObject component = null;
    public Material material = null;
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
        hologram.GetComponent<MeshRenderer>().enabled = false;
    }

    private void OnTriggerExit(Collider other)
    {
        hologram.GetComponent<MeshRenderer>().enabled = true;
    }
}
