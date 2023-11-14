using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverOptions : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   void  gameOver()
    {
        //end the game and load Game over screen
        UnityEngine.SceneManagement.SceneManager.LoadScene(3);
    }
}
