using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BtnType3 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public BTNType3 currentType;
    public Transform buttonScale;
    Vector3 defaultScale;
    public CanvasGroup mainGroup;

    private void Start(){
        defaultScale = buttonScale.localScale;
    }

    public void OnBtnClick(){
        switch(currentType){
            case BTNType3.Mini:
                SceneLoad3.LoadSceneHandle("Mini");
                break;
            case BTNType3.Quit:
                CanvasGroupOff(mainGroup);
                break;
        }
    }

    public void CanvasGroupOff(CanvasGroup cg)
    {
        cg.alpha = 0;
        cg.interactable = false;
        cg.blocksRaycasts = false;
    }

    public void OnPointerEnter(PointerEventData eventData){
        buttonScale.localScale = defaultScale*1.1f;
    }

    public void OnPointerExit(PointerEventData eventData){
        buttonScale.localScale = defaultScale;
    }
}
