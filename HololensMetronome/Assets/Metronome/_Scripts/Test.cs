using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI text;

    public void Tap()
    {
        text.text = "Test";
    }
}
