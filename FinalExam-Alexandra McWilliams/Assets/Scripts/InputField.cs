using UnityEngine;
using UnityEngine.UI;

public class InputField : MonoBehaviour
{
    public InputField NameField;
    public static string enterPlayerName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void UpdateName()
    {
        enterPlayerName = NameField.ToString();
    }
}
