using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public GameObject cam;
    private float speed;
    private bool isright;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        isright = transform.position.x > cam.transform.position.x;
        speed = UnityEngine.Random.Range(2, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if (isright)
        {
            transform.position += Vector3.left *speed *Time.deltaTime;
        }
        else if (!isright)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}
