using UnityEngine;

public class floatObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 1f;
    public float height = 0.5f;

    private float startY;

    void Start()
    {
        startY = transform.position.y;
    }

    void Update()
    {
        Vector3 pos = transform.position;
        pos.y = startY + Mathf.Sin(Time.time * speed) * height;
        transform.position = pos;
    }
}
