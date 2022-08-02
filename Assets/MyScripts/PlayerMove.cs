using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Cinemachine;

public class PlayerMove : MonoBehaviour
{
    NavMeshAgent nav;
    Animator anim;
    Ray ray;
    RaycastHit hit;

    float x;
    float z;
    float velocitySpeed;

    CinemachineTransposer ct;
    public CinemachineVirtualCamera playerCam;
    Vector3 pos;
    Vector3 currPos;

    public static bool canMove=true;
    public LayerMask moveLayer;

    private void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        ct = playerCam.GetCinemachineComponent<CinemachineTransposer>();

    }
    // Start is called before the first frame update
    void Start()
    {
        currPos = ct.m_FollowOffset;
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate velocity speed
        x = nav.velocity.x;
        z = nav.velocity.z;
        velocitySpeed = x + z;

        // Get mouse position
        pos = Input.mousePosition;
        ct.m_FollowOffset = currPos;
        //ct.m_FollowOffset=new Vector3(currPos.x,currPos.y*3,currPos.z*2);

        if (Input.GetMouseButtonDown(0))
        {
            if (canMove)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit,300,moveLayer))
                {
                    nav.destination = hit.point;
                }
            }
            
        }
        if (velocitySpeed != 0)
        {
            anim.SetBool("sprinting", true);
        }
        if (velocitySpeed == 0)
        {
            anim.SetBool("sprinting", false);
        }
        if (Input.GetMouseButton(1))
        {
            if (pos.x != 0 || pos.y != 0)
            {
                currPos = pos / 200;
            }
        }

    }

}
