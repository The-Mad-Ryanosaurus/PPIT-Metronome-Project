using TMPro;

using UnityEngine;

public class FadeOut : MonoBehaviour
{
    [SerializeField] private AnimationCurve fadeOutCurve;
    [SerializeField] private float fadeOutTime = 10f;
    private float fadeTimer = 0f;
    private TMP_Text text;

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        fadeTimer += Time.deltaTime;

        if (Input.anyKey)
        {
            fadeTimer = 0f;
        }

        Color color = text.color;
        color.a = fadeOutCurve.Evaluate(fadeTimer / fadeOutTime);
        text.color = color;
    }
}
