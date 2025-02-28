using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JeuV2 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _etiquettePoints;
    [SerializeField] private TextMeshProUGUI _temps;

    public int pointsJeu = 0;
    public int tempsJeu = 0;

    void Start()
    {
        tempsJeu = 0;
        InvokeRepeating("temps", 1f,1f);
        pointsJeu = 0;
    }

    public void AugmenterPoints()
    {
        // Augmenter les points du jeu
        pointsJeu++;
        // Actualiser l'UI
        _etiquettePoints.text = "$" + pointsJeu.ToString();
        pointsJeu++;
        _temps.text = tempsJeu.ToString();
    }
    void temps()
    {
        _temps.text = tempsJeu.ToString();
        tempsJeu++;
    }
}
