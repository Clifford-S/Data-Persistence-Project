using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class MenuUIHandler : MonoBehaviour
{
    public string userName;
    public GameObject inputField;
    public Text BestScoreText;

    [System.Serializable]
    class DataToSerialize
    {
        public string highUser;
        public int highScore;
    }

    public void Start()
    {
        LoadHighScore();
        BestScoreText.text = "Best Score = " + DataPacket.Instance.highUser + " " + DataPacket.Instance.highScore;
    }
    public void startButton()
    { 
        userName = inputField.GetComponent<Text>().text;
        DataPacket.Instance.userName = inputField.GetComponent<Text>().text;
        SceneManager.LoadScene(1);

    }
    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/HighScoreFile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            DataToSerialize data = JsonUtility.FromJson<DataToSerialize>(json);
            DataPacket.Instance.highUser = data.highUser;
            DataPacket.Instance.highScore = data.highScore;
        }
    }
}
