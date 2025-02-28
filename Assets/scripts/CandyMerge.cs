using UnityEngine;

public class CandyMerge : MonoBehaviour
{

    public bool merging;

    public GameObject candy;

    void Start()
    {
        merging = true;
    }

    void OnCollisionEnter2D(Collision2D collision)
    { 
        if (collision.gameObject.layer == 6 && candy.tag == collision.gameObject.tag)
        {
            Debug.Log("Inside!");
            merge(collision);
        }
    }

    void merge(Collision2D otherCandy)
    {
        if (merging == true)
        {
            otherCandy.gameObject.GetComponent<CandyMerge>().merging = false;
            Instantiate(candy, otherCandy.gameObject.transform.position, Quaternion.identity);
            Destroy(candy);
            Destroy(otherCandy.gameObject);
        }

        else
        {
            merging = true;
        }
        
    }
}

