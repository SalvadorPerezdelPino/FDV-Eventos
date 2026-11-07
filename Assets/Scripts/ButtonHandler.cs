using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public UnityEvent onCastleBack;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NotifyCastleBack()
    {
        onCastleBack.Invoke();
    }
}
