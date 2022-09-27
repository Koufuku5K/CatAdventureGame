using UnityEngine;

public class TreeStump : MonoBehaviour
{
    // Reference to tree stump generator
    public TreeStumpGenerator treeStumpGenerator;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * treeStumpGenerator.currentSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("nextLine"))
        {
            treeStumpGenerator.generateTreeStump();
        }
    }
}
