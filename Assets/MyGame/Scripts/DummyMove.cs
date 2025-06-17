using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class DummyMove : MonoBehaviour
{
    public float speed = 3.0f;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 move = transform.right * h + transform.forward * v;
        controller.Move(move * speed * Time.deltaTime);
    }
}
