using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtBarController : MonoBehaviour
{

    [SerializeField] TextMesh _player1Text, _player2Text;
    int _player1Heal=5, _player2Heal=5;
    private void OnTriggerEnter(Collider bullet)
    {
        if (bullet.gameObject.CompareTag("bullet2"))
        {
            if (gameObject.CompareTag("player1"))
            {
                _player1Heal--;
                _player1Text.text = _player1Heal.ToString();
            }
            Destroy(bullet.gameObject);

        }
        if (bullet.gameObject.CompareTag("bullet1"))
        {
            if (gameObject.CompareTag("player2"))
            {
                _player2Heal--;
                _player2Text.text = _player2Heal.ToString();
            }
            Destroy(bullet.gameObject);
        }
    }
}
