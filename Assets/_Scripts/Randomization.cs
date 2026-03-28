using UnityEngine;
using UnityEngine.UI;

public class Randomization : MonoBehaviour
{
    //spawnNewCustomer
    public Sprite[] customerSprites;
    public Image displayRenderer;

    //generateOrder()
    public TextAsset baseFile;
    public TextAsset frostingFile;
    public TextAsset tierFile;
    public TextAsset toppingsFile;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnNewCustomer();
        generateOrder();  
    }

    public void generateOrder()
    {
        string[] baseOptions = baseFile.text.Split(new[] { '\r', '\n' }, System.StringSplitOptions.RemoveEmptyEntries);
        string[] frostingOptions = frostingFile.text.Split(new[] { '\r', '\n' }, System.StringSplitOptions.RemoveEmptyEntries);
        string[] tierOptions = tierFile.text.Split(new[] { '\r', '\n' }, System.StringSplitOptions.RemoveEmptyEntries);
        string[] toppingsOptions = toppingsFile.text.Split(new[] { '\r', '\n' }, System.StringSplitOptions.RemoveEmptyEntries);

        string randomBase = baseOptions[Random.Range(0, baseOptions.Length)];
        string randomFrosting = frostingOptions[Random.Range(0, frostingOptions.Length)];
        string randomTier = tierOptions[Random.Range(0, tierOptions.Length)];
        string randomToppings = toppingsOptions[Random.Range(0, toppingsOptions.Length)];

        Debug.Log("Hello. Could I get a " + randomTier + " cake with a " + randomBase + " base with " + randomFrosting + " frosting.");
    }

    public void spawnNewCustomer() {
        int randomIndex = Random.Range(0, customerSprites.Length);
        displayRenderer.sprite = customerSprites[randomIndex];
        
        Debug.Log("A new customer has arrived! Index: " + randomIndex);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
