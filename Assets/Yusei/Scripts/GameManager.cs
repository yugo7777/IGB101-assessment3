using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject player;
    public int currentPickups = 0;
    public int maxPickups = 5;
    public bool levelcomplete = false;
    public Text pickupText;

    [SerializeField]
    [Header("Game Settings")]
    public AudioSource[] audioSources;
    public float audioProximity = 5.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       LevelcompleteCheck();
        UpdateGUI();
        PlayAudioSample();
    }
    private void LevelcompleteCheck()
    { 
        if (currentPickups >= maxPickups)
            levelcomplete = true;
        else
            levelcomplete = false;
    }
    void UpdateGUI() 
    { 
        pickupText.text = $"Pickups: {currentPickups}/{maxPickups}"; 
    }
    private void PlayAudioSample() 
    {
        for (int i = 0; i < audioSources.Length; i++)
        {
            float d = Vector3.Distance(player.transform.position, audioSources[i].transform.position);
            if (d <= audioProximity)
            {
                if (!audioSources[i].isPlaying)
                {
                    audioSources[i].Play();
                }
            }
            {
                
            }
        }
    }
}
