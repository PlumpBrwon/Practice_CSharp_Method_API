using UnityEngine;

public class Fox : MonoBehaviour
{
    [Header("²¾°Ê³t«×"), Range(0, 20)]
    public float speed=10;
    private Rigidbody2D rig;
    private SpriteRenderer spr;

    


    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        spr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {

        
        float hor = Input.GetAxis("Horizontal");
        print(hor);
        if (hor<0)
        {
            spr.flipX = true;
        }
        else
        {
            spr.flipX = false;
        }

        rig.AddForce(new Vector2(hor * speed,0));

        
    }
}
