using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public float Speed = 5;
    private float horizontalMove;
    private float verticalMove;
    private CharacterController CharacterController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CharacterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalMove, 0, verticalMove);
        CharacterController.Move(direction * Speed * Time.deltaTime);
    }
}
