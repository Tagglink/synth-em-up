using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 leftBottom = Camera.main.ScreenToWorldPoint(Vector3.zero);
        Vector2 rightTop = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, (float)Screen.height));
        Vector2 leftTop = new Vector2(leftBottom.x, rightTop.y);
        Vector2 rightBottom = new Vector2(rightTop.x, leftBottom.y);

        EdgeCollider2D collider = GetComponent<EdgeCollider2D>();
        collider.points = new Vector2[] { leftBottom, leftTop, rightTop, rightBottom, leftBottom };
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Bullet"))
        {
            Destroy(col.gameObject);
        }
    }
}
