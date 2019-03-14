using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float speed;

    private SmallShips.BaseBulletStarter bulletStarter;
    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        bulletStarter = GetComponent<SmallShips.BaseBulletStarter>();

        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float v_axis = Input.GetAxis("Vertical");
        bool fire1 = Input.GetButton("Fire1");

        Vector2 move_vector = new Vector2(0, speed * v_axis);
        body.velocity = move_vector;

        if (fire1)
        {
            bulletStarter.MakeOneShot();
        }
    }
}
