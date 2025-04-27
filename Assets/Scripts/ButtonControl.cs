using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonControl : MonoBehaviour
{
    TextMeshProUGUI text;

    ImageControl imageControl;

    public int num = 0;

    void Start()
    {
        imageControl = GameObject.FindWithTag("ImageGroup").GetComponent<ImageControl>();

        text = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        text.text = num.ToString();
    }

    public void OnClickedButton()
    {
        Vector2 pos = new Vector2(-400 * (num - 1), 0);
        
        imageControl.SetTargetPos(pos);
    }

    public void OnPointerEnter()
    {
        text.text = "Hover";
    }

    public void OnPointerExit()
    {
        text.text = num.ToString();
    }
}
