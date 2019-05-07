using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DropdownController : MonoBehaviour
{
    public Dropdown SizeDropdown;
    public static string size = "Default";
    public Dropdown SpeedDropdown;
    public static string speed = "Default";
    public Dropdown TimeDropdown;
    public static float timer = 15f;

    public Toggle MyToggle;

    public void Choice()
    {
        switch (SizeDropdown.value)
        {
            case 1:
                size = "Small";
                break;
            case 2:
                size = "Large";
                break;
            default:
                size = "Default";
                break;
        }
        switch (SpeedDropdown.value)
        {
            case 1:
                speed = "Slow";
                break;
            case 2:
                speed = "Fast";
                break;
            default:
                speed = "Default";
                break;
        }
        switch (TimeDropdown.value)
        {
            case 1:
                timer = 20f;
                break;
            case 2:
                timer = 40f;
                break;
            default:
                timer = 10f;
                break;
        }
    }

    public void Toggle_Changed(bool newValue)
    {
        SizeDropdown.enabled = newValue;
        SpeedDropdown.enabled = newValue;
        TimeDropdown.enabled = newValue;
    }
}
