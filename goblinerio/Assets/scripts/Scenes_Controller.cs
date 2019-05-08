using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenes_Controller : MonoBehaviour
{
    public void StarGame()
    {
        Application.LoadLevel(1);
    }

    public void ExitGame()
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

}
