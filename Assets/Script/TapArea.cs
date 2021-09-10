using UnityEngine;
using UnityEngine.EventSystems;

public class TapArea : MonoBehaviour, IPointerDownHandler
{
    public AudioSource GameClip;

    public void OnPointerDown (PointerEventData eventData)
    {
        GameClip.Play();
        GameManager.Instance.CollectByTap (eventData.position, transform);
    }
}