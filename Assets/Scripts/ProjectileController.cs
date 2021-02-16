using UnityEngine.Assertions;
using UnityEngine;
using UnityEngine.SceneManagement;
//[RequireComponent(typeof(ProjectileComponent))]
public class ProjectileController : MonoBehaviour
{
    [SerializeField]
    private float m_fInputDeltaVal = 0.1f;

    private ProjectileComponent m_projectile = null;

    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        m_projectile = GetComponent<ProjectileComponent>();
        Assert.IsNotNull(m_projectile, "Houston, we've got a problem! ProjectileComponent is not attached!");
    }

    // Update is called once per frame
    void Update()
    {
        HandleUserInput();
    }

    private void HandleUserInput()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            m_projectile.OnLaunchProjectile();
        }

        if (Input.GetKey(KeyCode.W))
        {
            m_projectile.OnMoveForward(m_fInputDeltaVal);
        }

        if (Input.GetKey(KeyCode.S))
        {
            m_projectile.OnMoveBackward(m_fInputDeltaVal);
        }

        if (Input.GetKey(KeyCode.D))
        {
            m_projectile.OnMoveRight(m_fInputDeltaVal);
        }

        if (Input.GetKey(KeyCode.A))
        {
            m_projectile.OnMoveLeft(m_fInputDeltaVal);
        }
        //Reset the position of the ball
        if (Input.GetKeyDown(KeyCode.R)) 
        {
            SceneManager.LoadScene("Play");
        }
    }
}
