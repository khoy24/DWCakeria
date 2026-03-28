using UnityEngine;
using UnityEngine.UI;

public class IngredientData : MonoBehaviour
{
    public enum Category { Tier, Base, Frosting }
    public Category myCategory;
    public string ingredientName; // Type "Chocolate", "Vanilla", etc. in Inspector

    private OrderManager manager;
    private Toggle myToggle;



    void Start()
    {
        // Try to find the object by its name in the Hierarchy
        // did this instead because of creation order
        GameObject managerObj = GameObject.Find("OrderManager");
        
        if (managerObj != null)
        {
            manager = managerObj.GetComponent<OrderManager>();
        }

        // debug purposes: if it's still null, show error
        if (manager == null)
        {
            Debug.LogError($"Null Error on {gameObject.name}: Can't find OrderManager!");
            return;
        }

        myToggle = GetComponent<Toggle>();
        if (myToggle != null)
        {
            myToggle.onValueChanged.AddListener(delegate { UpdateManager(); });
        }
    }

    void UpdateManager()
    {
        // only send the data if the toggle was turned on (clicked, green bg)
        if (myToggle.isOn)
        {
            if (myCategory == Category.Tier) manager.selectedTier = ingredientName;
            if (myCategory == Category.Base) manager.selectedBase = ingredientName;
            if (myCategory == Category.Frosting) manager.selectedFrosting = ingredientName;
            
            Debug.Log("Selected: " + ingredientName);
        }
    }
}