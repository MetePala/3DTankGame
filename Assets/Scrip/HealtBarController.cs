using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealtBarController : MonoBehaviour
{

    [SerializeField] TextMesh _player1Text, _player2Text;
    int _player1Heal=5, _player2Heal=5;
    [SerializeField] Text _winnerText;
    [SerializeField] GameObject _winPanel;

    private void OnCollisionEnter(Collision bullet)
    {
        if (bullet.gameObject.CompareTag("bullet2"))
        {
            if (gameObject.CompareTag("player1"))
            {
                _player1Heal--;
                _player1Text.text = _player1Heal.ToString();
            }
            StartCoroutine(Destroyy());
            Destroy(bullet.gameObject);

        }
        if (bullet.gameObject.CompareTag("bullet1"))
        {
            if (gameObject.CompareTag("player2"))
            {
                _player2Heal--;
                _player2Text.text = _player2Heal.ToString();
            }
            StartCoroutine(Destroyy());
            Destroy(bullet.gameObject);
        }

        if(_player2Heal ==0)
        {
            _winPanel.SetActive(true);
            _winnerText.text = "Winner Red";
            _winnerText.color = Color.red;
            Time.timeScale = 0;
        }
        if (_player1Heal == 0)
        {
            _winPanel.SetActive(true);
            _winnerText.text = "Winner Blue";
            _winnerText.color = Color.blue;
            Time.timeScale = 0;
        }
    }

    IEnumerator Destroyy()
    {
        yield return new WaitForSeconds(0.3f);
    }
}
