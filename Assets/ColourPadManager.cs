using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourPadManager : MonoBehaviour
{

    public static ColourPadManager instance;

    public List<GameObject> pads;
    public List<GameObject> boxes;
    public List<Color> possibleColours;

    public int totalCorrectPlacements;
    public int currentCorrectPlacements;
    public int placements;

    public Text canvasText;
    public UnityEvent completeEvent;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
}