using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private bool state;

    [SerializeField] private static GameManager instance;

    private void Awake()
    {
        instance = this;

    }
    public void Pause()
    {
        state = !state;
    }

}
