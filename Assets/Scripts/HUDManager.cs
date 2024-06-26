using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    public Image[] skins;
    public Image[] face;
    public Image[] lives;
    public Image[] crown;
    public Image[] inputs;
    public Image backother;

    public RectTransform start;
    public RectTransform move;

    public TMPro.TextMeshProUGUI timer;
    public TMPro.TextMeshProUGUI round;
    public TMPro.TextMeshProUGUI count;
    public TMPro.TextMeshProUGUI whoWins;

    void Start()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
            Destroy(gameObject);
        else
            DontDestroyOnLoad(gameObject);
    }

    public void Update()
    {
        if (SceneManager.GetActiveScene().name != "Lobby")
        {
            start.gameObject.SetActive(false);
            move.gameObject.SetActive(false);
        }
        else
        {
            start.gameObject.SetActive(true);
            move.gameObject.SetActive(true);
        }
    }

    public void StartTimer()
    {
        StartCoroutine(Timer());
    }

    public void StopTimer()
    {
        StopAllCoroutines();
    }

    private IEnumerator Timer()
    {
        float time = 0;
        while (true)
        {
            time += Time.deltaTime;
            timer.text = time.ToString("F2");
            yield return null;
        }
    }
}
