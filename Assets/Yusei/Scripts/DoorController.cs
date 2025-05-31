using UnityEngine;

public class DistanceDoorController : MonoBehaviour
{
    public Animation doorAnimation;
    public string animName = "Door test another test";
    public Transform mainCamera; 
    public float triggerDistance = 3.0f; 
    private bool isOpen = false;

    void Start()
    {
        if (mainCamera == null)
            mainCamera = Camera.main.transform;
    }

    void Update()
    {

        float distanceToCamera = Vector3.Distance(transform.position, mainCamera.position);

        if (distanceToCamera < triggerDistance && !isOpen)
        {
            OpenDoor();
        }
        else if (distanceToCamera >= triggerDistance && isOpen)
        {
            CloseDoor();
        }
    }

    void OpenDoor()
    {
        doorAnimation[animName].speed = 1;
        doorAnimation[animName].time = 0;
        doorAnimation.Play(animName);
        isOpen = true;
    }

    void CloseDoor()
    {
        doorAnimation[animName].speed = -1;
        doorAnimation[animName].time = doorAnimation[animName].length;
        doorAnimation.Play(animName);
        isOpen = false;
    }
}