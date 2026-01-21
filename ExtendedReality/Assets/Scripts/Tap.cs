using UnityEngine;
using UnityEngine.Events;

public class Tap : MonoBehaviour
{
    public UnityEvent OnPress;
    public UnityEvent OnRelease;
    public UnityEvent OnClick;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnMouseDown()
    {
        OnPress.Invoke();
    }

    void OnMouseUp()
    {
        OnRelease.Invoke();
    }
    void OnMouseUpAsButton()
    {
        OnClick.Invoke();
    }
}
