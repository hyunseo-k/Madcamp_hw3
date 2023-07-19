using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BtnType : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public BTNType currentType;
    public Transform buttonScale;
    Vector3 defaultScale;
    public CanvasGroup mainGroup;
    public CanvasGroup optionGroup;

    private void Start(){
        defaultScale = buttonScale.localScale;
    }
    bool isSound;
    public void OnBtnClick(){
        switch(currentType){
            case BTNType.New:
                SceneLoad.LoadSceneHandle("SampleScene", 0);
                break;
            case BTNType.Continue:
                SceneLoad.LoadSceneHandle("SampleScene", 1);
                break;
            case BTNType.Option:
                CanvasGroupOn(optionGroup);
                CanvasGroupOff(mainGroup);
                break;
            case BTNType.Sound:
                if(isSound){
                    // isSound = !isSound;
                    Debug.Log("사운드 off");
                }else{
                    // isSound = !isSound;
                    Debug.Log("사운드 on");
                }
                break;
            case BTNType.Back:
                CanvasGroupOn(mainGroup);
                CanvasGroupOff(optionGroup);
                Debug.Log("이어하기");
                break;
            case BTNType.Quit:
                Application.Quit();
                Debug.Log("앱종료");
                break;
        }
    }

    public void CanvasGroupOn(CanvasGroup cg)
    {
        cg.alpha = 1;
        cg.interactable = true;
        cg.blocksRaycasts = true;
    }
    public void CanvasGroupOff(CanvasGroup cg)
    {
        cg.alpha = 0;
        cg.interactable = false;
        cg.blocksRaycasts = false;
    }

    public void OnPointerEnter(PointerEventData eventData){
        buttonScale.localScale = defaultScale*1.2f;
    }

    public void OnPointerExit(PointerEventData eventData){
        buttonScale.localScale = defaultScale;
    }
    
}
