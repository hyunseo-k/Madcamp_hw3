using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum BTNType3{
    Mini,
    Quit
}

public class MainUI3 : MonoBehaviour
{
    public void SampleSceneBtn()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
