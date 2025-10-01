using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public static ScoreManager instance;

    int score = 0;
    int highscore = 0;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString() + "PUNTOS";
        ActualizarMarcador();
    }

    // Update is called once per frame
    public static void AgregarPuntos(int puntos)
    {
        instance.score += puntos;
        instance.ActualizarMarcador();

    }
     void ActualizarMarcador()
    {
        scoreText.text = score.ToString() + "PUNTOS";
    }
}
