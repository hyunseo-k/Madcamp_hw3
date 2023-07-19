using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum BTNType2{
    Hulala,
    Areum,
    Kaimaru,
    N1
}

public class MainUI2 : MonoBehaviour
{
    public void SampleSceneBtn()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
