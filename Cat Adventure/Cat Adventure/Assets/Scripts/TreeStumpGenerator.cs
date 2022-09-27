using UnityEngine;

public class TreeStumpGenerator : MonoBehaviour
{
    // Create a reference to the Tree Stump
    public GameObject treeStump;

    public float minSpeed;
    public float maxSpeed;
    public float currentSpeed;

    // Start is called before the first frame update
    void Awake()
    {
        currentSpeed = minSpeed;
        generateTreeStump();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void generateTreeStump()
    {
        GameObject treeStumpIns = Instantiate(treeStump, transform.position, transform.rotation);

        treeStumpIns.GetComponent<TreeStump>().treeStumpGenerator = this;
    }
}
