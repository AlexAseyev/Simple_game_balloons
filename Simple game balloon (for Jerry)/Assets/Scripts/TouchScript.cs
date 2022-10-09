using UnityEngine;
using UnityEngine.EventSystems;

public class TouchScript : MonoBehaviour, IPointerClickHandler
{
    public int balloonScopeVal;
    [SerializeField]

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        ClickCounter();
        Destroy(gameObject);
    }

    void ClickCounter()
    {
        if (PlayerPrefs.HasKey("SavedScope"))
        {
            int scopeToSave = PlayerPrefs.GetInt("SavedScope");
            scopeToSave += balloonScopeVal;
            PlayerPrefs.SetInt("SavedScope", scopeToSave);
            PlayerPrefs.Save();
        }
        else
        {
            PlayerPrefs.SetInt("SavedScope", balloonScopeVal);
            PlayerPrefs.Save();
        }
    }
}