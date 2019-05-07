using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text SpeedText;
    public Text SizeText;

    // Start is called before the first frame update
    void Start()
    {
        SpeedText.text = DropdownController.speed;
        SizeText.text = DropdownController.size;
    }


}
