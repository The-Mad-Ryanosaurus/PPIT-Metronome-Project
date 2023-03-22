using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private string color;
    [SerializeField] private Material material;

    [SerializeField] private MeshRenderer curve;
    [SerializeField] private MeshRenderer ball;

    private void Awake()
    {
        if (PlayerPrefs.GetString("Color") == color)
        {
            curve.material = material;
            ball.material = material;
            GetComponent<Toggle>().isOn = true;
        }
    }

    public void Change(bool state)
    {
        if (state)
        {
            curve.material = material;
            ball.material = material;
            PlayerPrefs.SetString("Color", color);
        }
    }
}
