using UnityEngine;

public class ColorSetting : MonoBehaviour
{
    [SerializeField] private Material red;
    [SerializeField] private Material green;
    [SerializeField] private Material blue;
    [SerializeField] private Material black;
    [SerializeField] private Material white;

    public void Start()
    {
        string color = PlayerPrefs.GetString("Color", "Red");
        MeshRenderer renderer = GetComponent<MeshRenderer>();

        switch (color)
        {
            default:
            case "Red":
                renderer.material = red;
                break;
            case "Green":
                renderer.material = green;
                break;
            case "Blue":
                renderer.material = blue;
                break;
            case "Black":
                renderer.material = black;
                break;
            case "White":
                renderer.material = white;
                break;
        }
    }
}
