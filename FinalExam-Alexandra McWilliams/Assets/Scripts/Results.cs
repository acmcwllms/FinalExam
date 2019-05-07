using UnityEngine;
using UnityEngine.UI;

public class Results : MonoBehaviour
{
    public Text Result;
    // Start is called before the first frame update
    void Start()
    {
        Result.text = "Score: " + ScoreKeeper.newScore + "\n"
            + "Lives: " + LivesTracker.lives + "\n";
    }

}
