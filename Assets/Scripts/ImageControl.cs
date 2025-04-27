using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageControl : MonoBehaviour
{
    RectTransform rectTransform;

    Vector2 targetPos;

    public float moveSpeed = 2000f;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        rectTransform.anchoredPosition = Vector2.MoveTowards(rectTransform.anchoredPosition, targetPos, moveSpeed * Time.deltaTime);
    }

    public void SetTargetPos(Vector2 pos)
    {
        targetPos = pos;
    }
}
