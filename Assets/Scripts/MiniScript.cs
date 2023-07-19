using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class MiniScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Transform buttonScale;
    Vector3 defaultScale;

    private void Start(){
        defaultScale = buttonScale.localScale;
    }

    public void OnBtnClick(){
        Debug.Log("으앙");
        SceneManager.LoadScene("Mini");
    }

    public void OnPointerEnter(PointerEventData eventData){
        buttonScale.localScale = defaultScale*1.1f;
    }

    public void OnPointerExit(PointerEventData eventData){
        buttonScale.localScale = defaultScale;
    }

}
