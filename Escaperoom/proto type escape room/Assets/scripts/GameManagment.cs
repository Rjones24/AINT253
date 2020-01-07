using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagment : MonoBehaviour
{
    [SerializeField] private float delay = 3f;
    private float timeElapsed;
    public static bool win = false;
    public static bool fail = false;
    public void StartGame()
    {
       
        SceneManager.LoadScene("wakeup", LoadSceneMode.Single);

    }


    private void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("wakeup"))
        {

            timeElapsed += Time.deltaTime;

            if (timeElapsed > delay)
            {
                SceneManager.LoadScene("Game", LoadSceneMode.Single);
                

            }
        }

        if (win)
        {
            winstate();
            win = false;
        }
        if (fail)
        {
            failstate();
            fail = false;
        }
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
    public void failstate()
    {
        SceneManager.LoadScene("fail", LoadSceneMode.Single);
        Cursor.lockState = CursorLockMode.None;
    }
    public void winstate()
    {
        SceneManager.LoadScene("Win", LoadSceneMode.Single);
        Cursor.lockState = CursorLockMode.None;
    }
}
