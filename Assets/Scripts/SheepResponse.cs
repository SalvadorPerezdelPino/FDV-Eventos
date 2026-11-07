using UnityEngine;

public class SheepResponse : MonoBehaviour
{
    public MeatNotifier meat;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meat.OnMeatEaten += RunAway;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RunAway()
    {
        transform.Translate(0, 2, 0);
    }
}
