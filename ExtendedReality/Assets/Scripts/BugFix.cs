using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

public class BugFix : MonoBehaviour
{
    protected void OnEnable()
    {
        EnhancedTouchSupport.Enable();
    }

    protected void OnDisable()
    {
        EnhancedTouchSupport.Disable();
    }
}
