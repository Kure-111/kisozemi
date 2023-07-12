using UnityEngine;
using TMPro;
using System.Collections;

public class Result : MonoBehaviour
{
    public TMP_Text gameOverText;
    public AudioSource BGM;
    public GameObject title;
    public TMP_Text Score;
    public TMP_Text Score1;

    void Start()
    {
        gameOverText.gameObject.SetActive(false);
        Score1.text = "";
        Score.text = "";
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayBGM();
        }
        int count = GameObject.FindGameObjectsWithTag("stage").Length;
        Score.text = "Score: " + (count - 1).ToString();
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("stage"))
        {
            // ゲームオーバーテキストの表示
            gameOverText.gameObject.SetActive(true);
            int count = GameObject.FindGameObjectsWithTag("stage").Length;
            BGM.Stop();
            Score1.text = "Score: " + (count - 1).ToString();
            StartCoroutine(WaitAndExecute(3f));
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            // ゲームオーバーテキストの表示
            gameOverText.gameObject.SetActive(true);
            int count = GameObject.FindGameObjectsWithTag("stage").Length;
            BGM.Stop();
            Score1.text = "Score: " + (count - 1).ToString();
            StartCoroutine(WaitAndExecute(3f));
        }
    }
    IEnumerator WaitAndExecute(float delay)
    {
        yield return new WaitForSeconds(delay);
        gameOverText.gameObject.SetActive(false);
        title.SetActive(true);
        Score1.text = "";
        Score.text = "";
        Debug.Log("3秒後に実行されました");
    }
    void PlayBGM()
    {
        if (!BGM.isPlaying)
        {
            BGM.Play();
            title.SetActive(false);
        }
    }
}

