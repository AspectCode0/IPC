using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public GameObject StartButton;

    public void SceneTransfer(string level)
    {
        SceneManager.LoadScene(level);
    }
}
