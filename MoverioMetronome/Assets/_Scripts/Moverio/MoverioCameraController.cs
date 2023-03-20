using UnityEngine;

public class MoverioCameraController : MonoBehaviour
{

    private static MoverioCameraController instance;

    //Makes sure the Prefab is added to the scene.
    public static MoverioCameraController Instance
    {
        get
        {
            if (instance == null)
            {
                Debug.Log("Please Add MoverioCameraRig Prefab To Scene!");
            }

            return instance;
        }
    }

    //Variables to take care of the various cameras.
    public Camera LeftEyeCam, RightEyeCam, Cam2D;

    public float PupillaryDistance = 0.05f;
    private MoverioDisplayType displayState;

    private void Awake()
    {
        instance = this;
    }

    //starts cameras to enable a full screen 2D view.
    private void Start()
    {
        LeftEyeCam.aspect = RightEyeCam.aspect = Screen.width / Screen.height * 2.0f;
        SetPupillaryDistance(PupillaryDistance);
    }


    //sets parameters to adjust the cameras when moving from 2D to 3D.
    public void SetPupillaryDistance(float pDist)
    {
        PupillaryDistance = pDist;

        LeftEyeCam.transform.localPosition = new Vector3(-PupillaryDistance, 0.0f, 0.0f);
        RightEyeCam.transform.localPosition = new Vector3(PupillaryDistance, 0.0f, 0.0f);
    }

    private void OnEnable()
    {
        MoverioController.OnMoverioStateChange += HandleOnMoverioStateChange;
    }

    private void OnDisable()
    {
        MoverioController.OnMoverioStateChange -= HandleOnMoverioStateChange;
    }

    //Function to handle switching from 2D to 3D.
    private void HandleOnMoverioStateChange(MoverioEventType type)
    {
        switch (type)
        {
            case MoverioEventType.Display3DOff:
            SetCurrentDisplayType(MoverioDisplayType.Display2D);
            break;
            case MoverioEventType.Display3DOn:
            SetCurrentDisplayType(MoverioDisplayType.Display3D);
            break;
        }

    }

    //Reads current display mode.
    public MoverioDisplayType GetCurrentDisplayState()
    {
        return displayState;
    }

    //creates switches between a signle camera mode and double camera mode
    //for 2D and 3D switching.
    public void SetCurrentDisplayType(MoverioDisplayType type)
    {
        displayState = type;

        switch (displayState)
        {
            case MoverioDisplayType.Display2D:
            LeftEyeCam.enabled = RightEyeCam.enabled = false;
            Cam2D.enabled = true;
            break;
            case MoverioDisplayType.Display3D:
            LeftEyeCam.enabled = RightEyeCam.enabled = true;
            Cam2D.enabled = false;
            break;
        }
    }


}
