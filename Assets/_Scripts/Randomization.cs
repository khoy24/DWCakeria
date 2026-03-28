using UnityEngine;

public class Randomization : MonoBehaviour
{
    public TextAsset baseFile;
    public TextAsset frostingFile;
    public TextAsset tierFile;
    public TextAsset toppingsFile;
    public TextAsset dialougeFile; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        generateOrder();  
    }

    public void generateOrder()
    {
        string[] baseOptions = baseFile.text.Split('\n');
        string[] frostingOptions = frostingFile.text.Split('\n');
        string[] tierOptions = tierFile.text.Split('\n');
        string[] toppingsOptions = toppingsFile.text.Split('\n');
        string[] dialougeOptions = dialougeFile.text.Split('\n');

        string randomBase = baseOptions[Random.Range(0, baseOptions.Length)];
        string randomFrosting = frostingOptions[Random.Range(0, frostingOptions.Length)];
        string randomTier = tierOptions[Random.Range(0, tierOptions.Length)];
        string randomToppings = toppingsOptions[Random.Range(0, toppingsOptions.Length)];
        string randomDialouge = dialougeOptions[Random.Range(0, dialougeOptions.Length)];

        Debug.Log("Order: " + randomBase + " cake with " + randomFrosting + " frosting, " + randomTier + " tiers, and " + randomToppings + " toppings. Customer says: " + randomDialouge);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
