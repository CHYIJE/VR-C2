using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class VROutlineSelection : MonoBehaviour
{
    private Transform highlight;
    private Transform selection;

    public OVRInput.Controller controller; // Oculus 컨트롤러를 지정
    public OVRRaycaster raycaster; // Oculus 컨트롤러의 OVRRaycaster를 참조

    void Update()
    {
        // Highlight
        if (highlight != null)
        {
            highlight.gameObject.GetComponent<Outline>().enabled = false;
            highlight = null;
        }

        // OVRRaycaster의 Ray를 직접 가져오는 대신 PhysicsRaycaster를 사용하여 Ray를 감지
        PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
        pointerEventData.position = new Vector2(Screen.width / 2, Screen.height / 2);
        List<RaycastResult> raycastResults = new List<RaycastResult>();
        raycaster.Raycast(pointerEventData, raycastResults);

        // 레이 충돌 감지
        if (raycastResults.Count > 0)
        {
            highlight = raycastResults[0].gameObject.transform;
            if (highlight.CompareTag("Selectable") && highlight != selection)
            {
                if (highlight.gameObject.GetComponent<Outline>() != null)
                {
                    highlight.gameObject.GetComponent<Outline>().enabled = true;
                }
                else
                {
                    Outline outline = highlight.gameObject.AddComponent<Outline>();
                    outline.enabled = true;
                    highlight.gameObject.GetComponent<Outline>().OutlineColor = Color.magenta;
                    highlight.gameObject.GetComponent<Outline>().OutlineWidth = 7.0f;
                }
            }
            else
            {
                highlight = null;
            }
        }

        // Selection
        if (OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad, controller))
        {
            if (highlight)
            {
                if (selection != null)
                {
                    selection.gameObject.GetComponent<Outline>().enabled = false;
                }
                selection = raycastResults[0].gameObject.transform;
                selection.gameObject.GetComponent<Outline>().enabled = true;
                highlight = null;
            }
            else
            {
                if (selection)
                {
                    selection.gameObject.GetComponent<Outline>().enabled = false;
                    selection = null;
                }
            }
        }
    }
}
