#define UNITYANDROID
#undef UNITYEDITOR

using UnityEngine;


public enum MoverioEventType
{
    Display3DOn,
    Display3DOff,
    DisplayBrightnessChange,

    MuteDisplayOn,
    MuteDisplayOff,

}

//Set Parameters to remember if the display
//is in 2D or 3D mode.

public enum MoverioDisplayType
{
    Display3D,
    Display2D
}



public class MoverioController : MonoBehaviour
{
    public delegate void MoverioEvent(MoverioEventType type);
    public static event MoverioEvent OnMoverioStateChange;

    //Define default parameters for the Moverio.

    public int InitialScreenBrightness = 20;

    public MoverioDisplayType InitialDisplayMode = MoverioDisplayType.Display2D;


    private AndroidJavaClass unityPlayer;
    private AndroidJavaObject currentActivity;

    private static MoverioController instance;

    //Reminds developers to place the Moverio Prefabs into
    //their scene.
    public static MoverioController Instance
    {
        get
        {
            if (instance == null)
            {
                Debug.Log("Please Add MoverioController Prefab To Scene!");
            }
            return instance;
        }
    }

    public bool MoverioDevice { get; private set; }

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {

        CheckDeviceType();

        SetJavaClass();

        SetDefaultSettings();

    }

    //Function to make sure the device is a Moverio BT-300.
    private void CheckDeviceType()
    {
        if (SystemInfo.deviceModel.Equals("EPSON EMBT3C"))
        {
            AndroidJNI.AttachCurrentThread();
        }
        else
        {
            MoverioDevice = false;
        }
    }

    //Sets Display to full brightness and 2D mode by default.
    private void SetDefaultSettings()
    {
        if (InitialDisplayMode.Equals(MoverioDisplayType.Display3D))
        {
            SetDisplay3D(true);
        }
        else
        {
            SetDisplay3D(false);
        }

        if (!InitialScreenBrightness.Equals(20))
        {
            string msg = SetDisplayBrightness(InitialScreenBrightness);

            Debug.Log(msg);
        }

    }

    private void SetJavaClass()
    {
#if UNITYANDROID && !UNITYEDITOR

        if (MoverioDevice)
        {
            using (unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            {
                currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
            }

            currentActivity.Call("SetMoverioDevice");
        }

#endif
    }

    //function that enables developers to recieve sensor data from the Moverio.

    public static float[] GetSensorData(MoverioInput sensorType)
    {
        float[] value = null;

#if UNITYANDROID && !UNITYEDITOR

        if (Instance.MoverioDevice)
        {
            value = Instance.currentActivity.Call<float[]>("GetSensorData", (int)sensorType);
        }

#endif
        return value;
    }

    //Recognizes a headset tap.
    public static bool GetHeadsetTap()
    {
        bool value = false;

#if UNITYANDROID && !UNITYEDITOR

        if (Instance.MoverioDevice)
        {
            value = Instance.currentActivity.Call<bool>("GetHeadsetTap");
        }

#endif
        return value;
    }

    //function to keep count of how many headset taps have occurred.
    public static int GetHeadsetTapCount()
    {
        int value = 0;

#if UNITYANDROID && !UNITYEDITOR

        if (Instance.MoverioDevice)
        {
            value = Instance.currentActivity.Call<int>("GetHeadsetTapCount");
        }

#endif
        return value;
    }



    /*
	 *
	 * SetDisplayBrightness takes an int between 0 - 20
	 * will automatically return an ERROR msg for out of range
	 *
	 */


    public static string SetDisplayBrightness(int brightness)
    {
        string msg = "NOT SET";

#if UNITYANDROID && !UNITYEDITOR

        if (Instance.MoverioDevice)
        {
            msg = Instance.currentActivity.Call<string>("SetDisplayBrightness", brightness);
        }

#endif

        OnMoverioStateChange?.Invoke(MoverioEventType.DisplayBrightnessChange);

        return msg;
    }

    /*
	 *
	 * Gets Current Display Brightness level (an int between 0 - 20)
	 *
	 */

    public static int GetDisplayBrightness()
    {
        int i = -1;

#if UNITYANDROID && !UNITYEDITOR

        if (Instance.MoverioDevice)
        {
            i = Instance.currentActivity.Call<int>("GetDisplayBrightness");
        }

#endif

        return i;
    }

    /*
	 *
	 * Sets 3D Display toggle on/off
	 *
	 */

    public static void SetDisplay3D(bool on)
    {
#if UNITYANDROID && !UNITYEDITOR

        if (Instance.MoverioDevice)
        {
            Instance.currentActivity.Call("SetDisplay3D", on);
        }

#endif

        if (OnMoverioStateChange != null)
        {
            MoverioEventType eType;

            if (on)
            {
                eType = MoverioEventType.Display3DOn;
            }
            else
            {
                eType = MoverioEventType.Display3DOff;
            }

            OnMoverioStateChange(eType);
        }
    }




    /*
	 *
	 * Sets Mute Display toggle on/off
	 *
	 */

    public static void MuteDisplay(bool mute)
    {

#if UNITYANDROID && !UNITYEDITOR

        if (Instance.MoverioDevice)
        {
            Instance.currentActivity.Call("MuteDisplay", mute);
        }

#endif

        if (OnMoverioStateChange != null)
        {
            MoverioEventType eType;

            if (mute)
            {
                eType = MoverioEventType.MuteDisplayOn;
            }
            else
            {
                eType = MoverioEventType.MuteDisplayOff;
            }

            OnMoverioStateChange(eType);
        }


    }


}
