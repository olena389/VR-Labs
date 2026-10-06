
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Перевірка, чи підключена клавіатура
        Keyboard keyboard = Keyboard.current;
        if (keyboard == null) return;

        float moveHorizontal = 0f;
        float moveVertical = 0f;

        // Керування клавішами W, A, S, D або стрілочками
        if (keyboard.wKey.isPressed || keyboard.upArrowKey.isPressed) moveVertical += 1f;
        if (keyboard.sKey.isPressed || keyboard.downArrowKey.isPressed) moveVertical -= 1f;
        if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed) moveHorizontal += 1f;
        if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed) moveHorizontal -= 1f;

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
}