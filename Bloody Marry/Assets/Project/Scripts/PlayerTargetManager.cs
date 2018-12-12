using UnityEngine;

public class PlayerTargetManager : MonoBehaviour
{
    public static PlayerTargetManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    [SerializeField] private GameObject m_playerTarget;

    public GameObject PlayerTarget
    {
        get
        {
            return m_playerTarget;
        }

        set
        {
            m_playerTarget = value;
        }
    }


}