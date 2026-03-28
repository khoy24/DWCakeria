using UnityEngine;

public class ToggleScrollView : MonoBehaviour
{
    public GameObject scrollView;

    public void Toggle()
    {
        Debug.Log("Toggle called! Scroll View is: " + scrollView);
        bool isActive = scrollView.activeSelf;
        scrollView.SetActive(!isActive);
        Debug.Log("Set active to: " + !isActive);
    }
}