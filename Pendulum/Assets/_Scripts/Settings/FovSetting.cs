using UnityEngine;

public class FovSetting : MonoBehaviour
{
    private Camera cam;

    private void Awake()
    {
        cam = GetComponent<Camera>();
    }

    private void Update()
    {
        cam.fieldOfView = Settings.FieldOfView;
    }
}
