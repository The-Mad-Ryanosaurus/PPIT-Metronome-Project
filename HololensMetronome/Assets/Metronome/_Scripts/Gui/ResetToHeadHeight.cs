using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetToHeadHeight : MonoBehaviour
{
    public void Reset()
    {
        var cam = FindObjectOfType<Camera>();

        PlayerPrefs.SetFloat("Height", cam.transform.position.y);
    }
}
