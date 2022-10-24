using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class TitleScene : MonoBehaviour
{
    void Start()
    {
        Invoke("ChangeScene", 1.5f);
    }
    void Update()
    {
    }
    void ChangeScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
