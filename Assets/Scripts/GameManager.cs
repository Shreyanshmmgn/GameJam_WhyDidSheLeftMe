using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    bool gameHasEnded = false;
    public void EndGame(){
        if(gameHasEnded == false)
        {
        gameHasEnded=true;
         restart();
        }
    }
    void Start()
    {
        
    }
    public void restart(){
        
        SceneManager.LoadScene("Scene1");
    }
    public void back()
    {
        SceneManager.LoadScene("Menu");
    }

    public void winGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void exit()
    {
        Application.Quit();
    }
}
