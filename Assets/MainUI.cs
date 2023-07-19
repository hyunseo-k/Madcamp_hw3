using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum BTNType
{
    New,
    Continue,
    Option,
    Sound,
    Back,
    Quit
}

public class MainUI : MonoBehaviour
{
    public void SampleSceneBtn()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
