using UnityEngine;

public class TreeStumpGenerator : MonoBehaviour
{
    // Create a reference to the Tree Stump
    public GameObject treeStump;

    public float minSpeed;
    public float maxSpeed;
    public float currentSpeed;

    public float speedMultiplier;

    // Start is called before the first frame update
    void Awake()
    {
        currentSpeed = minSpeed;
        generateTreeStump();
    }

    // Update is called once per frame
    void Update()
    {
        if(currentSpeed < maxSpeed)
        {
            currentSpeed += speedMultiplier;
        }
    }

    void generateTreeStump()
    {
        GameObject treeStumpIns = Instantiate(treeStump, transform.position, transform.rotation);

        treeStumpIns.GetComponent<TreeStump>().treeStumpGenerator = this;
    }

    public void generateNextTreeStumpWithGap()
    {
        float waitGenerateNext = Random.Range(0.1f, 2.0f);
        Invoke("generateTreeStump", waitGenerateNext);
    }
}
