using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void EnterGame()
    {
        SceneManager.LoadScene("2HighScores");
    }

    public void StopPlaying()
    {
        SceneManager.LoadScene("4Exit");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("1Intro");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("3Game");
    }

    public void EndGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
