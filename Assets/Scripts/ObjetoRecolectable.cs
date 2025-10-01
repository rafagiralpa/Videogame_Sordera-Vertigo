using UnityEngine;

public class ObjetoRecolectable : MonoBehaviour
{
    public string lugarCorrectoTag; // Etiqueta del objeto donde se debe colocar
    public int puntosPorColocacion = 1; // Puntos otorgados por colocar el objeto correctamente

    private bool bienColoc = false; // Estado del objeto (colocado o no)

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(lugarCorrectoTag) && !bienColoc)
        {
            // Objeto colocado correctamente
            bienColoc = true;
            ScoreManager.AgregarPuntos(puntosPorColocacion);
        }
    }
}