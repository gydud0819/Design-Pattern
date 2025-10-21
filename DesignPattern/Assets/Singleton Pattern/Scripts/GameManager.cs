using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private bool state;

    [SerializeField] private static GameManager instance;

    public static GameManager Instance { get { return instance; } }
    public bool State { get { return state; } }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void Pause()
    {
        state = !state;
    }

}
