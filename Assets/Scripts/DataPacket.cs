using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPacket : MonoBehaviour
{
    public static DataPacket Instance;
    public  string userName;
    public string highUser;
    public  int highScore;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
