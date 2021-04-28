using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(ToMenuExiter))]
public class CreditsScroller : MonoBehaviour
{
    [SerializeField] private float _scrollSpeed;
    [SerializeField] private RectTransform _content;

    private ToMenuExiter _toMenuExiter;

    private void Awake()
    {
        _toMenuExiter = GetComponent<ToMenuExiter>();
    }

    private void Start()
    {
        StartCoroutine(AutoScroll());
    }

    private IEnumerator AutoScroll()
    {
        while (_content.position.y < Screen.height - _content.rect.y)
        {
            _content.Translate(Vector3.up * _scrollSpeed * Time.deltaTime);
            yield return null;
        }

        _toMenuExiter.ExitToMenu();
    }
}
