using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody rigid;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] float jumpPower;

    [SerializeField] int score;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { Jump(); }
    }

    void Jump()
    {
        rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        score++;
        scoreText.text = $"현재 스코어는 : {score}";
    }
}
