using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagment : MonoBehaviour
{
    [SerializeField] private float delay = 3f;
    private bool wokenUp = false;
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
                wokenUp = true;

            }
        }

        if (win)
        {
            winstate();
        }
        if (fail)
        {
            failstate();
        }
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("", LoadSceneMode.Single);
    }
    public void failstate()
    {
        SceneManager.LoadScene("fail", LoadSceneMode.Single);
    }
    public void winstate()
    {
        SceneManager.LoadScene("Win", LoadSceneMode.Single);
    }
}
