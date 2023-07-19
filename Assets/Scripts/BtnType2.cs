using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BtnType2 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public BTNType2 currentType;
    public Transform buttonScale;
    Vector3 defaultScale;

    private void Start(){
        defaultScale = buttonScale.localScale;
    }

    public void OnBtnClick(){
        switch(currentType){
            case BTNType2.Hulala:
                SceneLoad2.LoadSceneHandle("Hulala");
                break;
            case BTNType2.Areum:
                SceneLoad2.LoadSceneHandle("Areum");
                break;
            case BTNType2.Kaimaru:
                SceneLoad2.LoadSceneHandle("Kaimaru");
                break;
            case BTNType2.N1:
                SceneLoad2.LoadSceneHandle("N1");
                break;
        }
    }

    public void OnPointerEnter(PointerEventData eventData){
        buttonScale.localScale = defaultScale*1.1f;
    }

    public void OnPointerExit(PointerEventData eventData){
        buttonScale.localScale = defaultScale;
    }
}
