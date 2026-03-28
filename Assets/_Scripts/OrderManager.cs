using UnityEngine;
using UnityEngine.UI;

public class OrderManager : MonoBehaviour
{
    // store the name of the currently selected items
    public string selectedTier;
    public string selectedBase;
    public string selectedFrosting;

    // from your Submit Button
    public void SubmitOrder()
    {
        if (string.IsNullOrEmpty(selectedTier) || string.IsNullOrEmpty(selectedBase))
        {
            Debug.Log("Order incomplete!");
            return;
        }

        Debug.Log($"Recipe Sent: {selectedTier} cake with {selectedBase} and {selectedFrosting} frosting!");
        // Here is where you would pass these strings to your Recipe Card UI
    }
}