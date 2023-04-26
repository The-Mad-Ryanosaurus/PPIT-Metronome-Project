using System;
using System.Collections;
using UnityEngine;

public class HeightAndDistanceSetting : MonoBehaviour
{
    float headHeight = 0;
    float headsmoothHeight = 0;

    void Start()
    {
        StartCoroutine(Head_Couroutine());
    }

    private IEnumerator Head_Couroutine()
    {
        while (true)
        {
            headHeight = Camera.main.transform.position.y;
            yield return new WaitForSeconds(3);
        }
    }

    private void Update()
    {
        headsmoothHeight = Mathf.MoveTowards(headsmoothHeight, headHeight, Time.deltaTime);
        transform.localPosition = new Vector3(0, headsmoothHeight + PlayerPrefs.GetFloat("Height"), PlayerPrefs.GetFloat("Distance"));
    }
}
