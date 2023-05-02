using UnityEngine;
using UnityEngine.AI;

public class FarmerController : MonoBehaviour
{
    public LayerMask filterLayerFarmer;
    public LayerMask filterLayerEnv;
    
    public GameObject objectToActivate;
    public bool selectionactive = false;
    private NavMeshAgent farmeragent;
    private Animator _animator;

    [SerializeField] private bool walking = false;

    private void Start()
    {
        farmeragent = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();
        objectToActivate.SetActive(false);
    }

    private void Update()
    {
        //Debug.Log(selectionactive);

        if (Input.GetMouseButtonDown(0) && selectionactive == false)
        {
            RaycastHit hitInfo;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, Mathf.Infinity, filterLayerFarmer))
            {
                if (hitInfo.transform.gameObject == gameObject)
                {
                    Invoke("activateselction", .25f);
 
                    Debug.Log("Called");
                    Debug.Log(selectionactive);
                    objectToActivate.SetActive(true);
                    walking = true;
                }
                
            }
            
        }
        if (Input.GetMouseButton(0) && selectionactive == true)
            {
                RaycastHit hitloc;
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitloc, Mathf.Infinity, filterLayerEnv))
                {
                    Vector3 hitTransform = hitloc.point;
                    Debug.Log("The transform of the clicked place is: " + hitTransform);
                    farmeragent.SetDestination(hitTransform);
                    _animator.SetBool("Walk", true);
                    selectionactive = false;
                    objectToActivate.SetActive(false);
                }
            }

        if (farmeragent.remainingDistance <= farmeragent.stoppingDistance && !farmeragent.pathPending)
        {
            if (!farmeragent.hasPath || farmeragent.velocity.sqrMagnitude == 0f)
            {
                // The agent has reached its destination
                _animator.SetBool("Walk", false);
                Debug.Log("Agent has reached its destination.");
                walking = false;
            }
        }
    }

    private void activateselction()
    {
        selectionactive = true;
    }
}