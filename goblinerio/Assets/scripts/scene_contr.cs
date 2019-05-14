using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class scene_contr : MonoBehaviour
    
{
    public int Scene = 2;
    
    
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player") 
        {
            SceneManager.LoadScene(Scene); 
        }

    }
    public void LoadLevel1()
    {
        Application.LoadLevel(1);
    }
    public void LoadLevel2()
    {
        Application.LoadLevel(2);
    }
    public void ExitToDesktop()
    {
        Application.Quit();
    }
    
    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.LoadLevel(0);
        }
    }
    public void ExitToMenu()
    {
        Application.LoadLevel(0);
    }

}
