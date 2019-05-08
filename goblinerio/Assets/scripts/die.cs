using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class die : MonoBehaviour
{
    public GameObject caracter;

    private bool live = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (live == true)
        {

        }
    }
    public void OnTriggerEnter(Collider collider)
    {
        live = false;
        SceneManager.LoadScene(1);
    }
    
    
}
