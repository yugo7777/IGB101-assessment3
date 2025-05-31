using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSwitch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    [Header("Level Switch Settings")]
    GameManager gameManager;
    public string nextLevel;
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider otherObject)
    {
        
        if (otherObject.transform.tag == "Player")
        {
            if (gameManager.maxPickups > gameManager.currentPickups)
            {
                Debug.Log("You need to collect all pickups before switching levels.");
                return;
            }
            else
            {
                Destroy(this.gameObject);
                SceneManager.LoadScene(nextLevel);
            }
                
        }

    }
}

