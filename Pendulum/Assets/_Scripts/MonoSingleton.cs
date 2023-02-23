using UnityEngine;

public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
    private static T instance;
    public static T I
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<T>();
            }

            if (instance == null)
            {
                GameObject obj = new($"Singleton of {typeof(T)}");
                instance = obj.AddComponent<T>();
            }

            return instance;
        }
    }
}
