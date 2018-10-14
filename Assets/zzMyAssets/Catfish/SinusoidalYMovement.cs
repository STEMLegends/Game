using Gamekit2D;
using UnityEngine;

public class SinusoidalYMovement : MonoBehaviour {

    protected CharacterController2D m_CharacterController2D;
    public float scale = 5;

    void Start()
    {
        m_CharacterController2D = GetComponent<CharacterController2D>();
    }

    void FixedUpdate()
    {
        Vector2 new_position = new Vector2(x: 0.0f, y: Mathf.Sin(Time.fixedTime)*scale);
        m_CharacterController2D.Move(new_position);

    }
}
