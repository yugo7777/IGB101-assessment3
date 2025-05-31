using UnityEngine;

public class DoorTest : MonoBehaviour
{
    private Animation _animation;

    void Start()
    {
        _animation = GetComponent<Animation>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("r key pressed!");
            if (_animation != null)
            {
                Debug.Log("Animation component found!");
                _animation.Play();
            }
            else
            {
                Debug.LogWarning("Animation component not found!");
            }
        }
    }
}
