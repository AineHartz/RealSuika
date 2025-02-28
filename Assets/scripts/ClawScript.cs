using UnityEngine;

public class ClawScript : MonoBehaviour
{
    Camera cam;
    public Vector2 mousePos;
    public GameObject claw;
    Rigidbody2D body;
    public GameObject candy;

    public float minX;
    public float maxX;

    void Start()
    {
        cam = Camera.main;
        body = claw.GetComponent<Rigidbody2D>();

    }


    void FixedUpdate()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        if(mousePos.x >= minX && mousePos.x <= maxX)
        {
            body.MovePosition(mousePos);
        }
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) == true)
        {
            Instantiate(candy, claw.transform.position, Quaternion.identity);
        }
    }
}
