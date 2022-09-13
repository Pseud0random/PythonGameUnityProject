using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{

    public Animator animator;

    private int levelToLoad;
    void Update()
    {
        //this will change to if collides with door trig
        if (Input.GetMouseButtonDown(0))
        {
            FadeToLevel(3);
        }
    }

    public void FadeToLevel (int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("Fade out");
    }

    public void OnFaceComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
