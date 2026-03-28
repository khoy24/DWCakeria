using UnityEngine;

public class Randomization : MonoBehaviour
{
    public TextAsset baseFile;
    public TextAsset frostingFile;
    public TextAsset tierFile;
    public TextAsset toppingsFile;

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
        string[] toppingsOptions = toppingsFile.text.Split('\n')

        string randomBase = baseOptions[Random.Range(0, baseOptions.Length)];
        string randomFrosting = frostingOptions[Random.Range(0, frostingOptions.Length)];
        string randomTier = tierOptions[Random.Range(0, tierOptions.Length)];
        string randomToppings = toppingsOptions[Random.Range(0, toppingsOptions.Length)];

        Debug.Log("Hello. Could I get a " + randomTier + " cake with a " + randomBase + " base with " + randomFrosting + " frosting.");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
