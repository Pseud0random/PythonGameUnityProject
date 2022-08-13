using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourPadManager : MonoBehaviour
{

    public static ColourPadManager instance;
    public List<GameObject> pads;
    public List<GameObject> boxes;
    public List<Color> possibleColours;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
