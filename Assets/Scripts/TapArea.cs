using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TapArea : MonoBehaviour, IPointerDownHandler
{
    private AudioSource Tap;

    void Start()
    {
        Tap = GetComponent<AudioSource>();

    }


    public void OnPointerDown(PointerEventData eventData)

    {

        GameManager.Instance.CollectByTap(eventData.position, transform);
        Tap.Play();

    }
}
