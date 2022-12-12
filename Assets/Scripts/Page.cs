using UnityEngine;

public class Page : MonoBehaviour
{
    public virtual void ShowCanvas()
    {
        gameObject.SetActive(true);
    }
    
    public virtual void HideCanvas()
    {
        gameObject.SetActive(false);
    }
}