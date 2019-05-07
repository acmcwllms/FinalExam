using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static float timePlayed;
    public Text timeText;

    private void Start()
    {
        timePlayed = DropdownController.timer;
    }
    // Update is called once per frame
    void Update()
    {
        timePlayed -= Time.deltaTime;
        timeText.text = timePlayed.ToString();
        if(timePlayed <= 0f)
        {
            SceneManager.LoadScene("4Exit");
        }
    }
}
