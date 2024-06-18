using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public enum E_DirectionType
    {
        Up = 0,
        Down,
        Left,
        Right
    }

    [SerializeField] protected E_DirectionType m_DirectionType = E_DirectionType.Up;
    protected void SetPlayerMove(E_DirectionType p_movetype) 
    {
        Vector3 offsetpos = Vector3.zero;

        switch(p_movetype)
        {
            case E_DirectionType.Up:
                offsetpos = Vector3.forward;
                break;
            case E_DirectionType.Down:
                offsetpos = Vector3.back;
                break;
            case E_DirectionType.Left:
                offsetpos = Vector3.left;
                break;
            case E_DirectionType.Right:
                offsetpos = Vector3.right;
                break;
            default:
                Debug.LogErrorFormat("SetPlayerMove Error : {0}", p_movetype);
                break;
        }
        this.transform.position = offsetpos;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            SetPlayerMove(E_DirectionType.Up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            SetPlayerMove(E_DirectionType.Down);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SetPlayerMove(E_DirectionType.Left);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SetPlayerMove(E_DirectionType.Right);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag.Contains("Crash"))
        {
            
        }
    }

    protected void OnTriggerExit(Collider other)
    {
        
    }
}
