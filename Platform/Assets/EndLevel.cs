using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    //public int nextSceneLoad;
    //void Start()
    //{
    //    nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;    
    //}
    public GameObject youWinUI;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))
        {
            //SceneManager.LoadScene("YouWin");
            //SceneManager.LoadScene(nextSceneLoad);

            //if (nextSceneLoad>PlayerPrefs.GetInt("levelAt"))
            //{
            //    PlayerPrefs.SetInt("levelAt", nextSceneLoad);
            //}

            youWinUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }


}
