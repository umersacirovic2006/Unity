using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextChange : MonoBehaviour
{
    [Header("Text")]
    public GameObject speed;
    public GameObject state;

    [Header("Game Variables")]
    public float Speed;
    public GameObject Player;
    public string State;

    TextMeshProUGUI tmp_speed;
    TextMeshProUGUI tmp_state;

    void Start()
    {
        tmp_speed = speed.GetComponent<TextMeshProUGUI>();
        tmp_state = state.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        tmp_speed.text = Player.GetComponent<PlayerMovement>().movementSpeed.ToString();
        tmp_state.text = Player.GetComponent<PlayerMovement>().state.ToString();
    }
}
