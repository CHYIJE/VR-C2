using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnOffButtonController : MonoBehaviour
{
    public MixObjectController mixController; // MixObjectController에 대한 레퍼런스

    void OnMouseDown()
    {
        // On/Off 버튼 클릭 시 동작을 수행합니다.
        mixController.OnMixObjectToggle();
    }
}