using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float RestartDelay = 1f;
    public GameObject comleteLevelUI;
    public void CompleteLevel ()
    {
        comleteLevelUI.SetActive(true);
        SceneManager.LoadScene("Quit Menu");
    }
    public void GameEnd()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", RestartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
