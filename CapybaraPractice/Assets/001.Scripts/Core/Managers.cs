using Unity.VisualScripting;
using UnityEngine;

public class Managers : MonoBehaviour
{
    public static Managers Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject go = GameObject.Find($"@{typeof(Managers).Name}");
                if (go == null)
                    go = new GameObject($"@{typeof(Managers).Name}");
                instance = go.GetOrAddComponent<Managers>();
            }
            return instance;
        }
    }
    public static Managers instance;

    public void Awake()
    {
        _ = Instance;
    }
}
