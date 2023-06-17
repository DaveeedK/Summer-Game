using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PartsCounter : MonoBehaviour
{

    public static PartsCounter instance;

    public TMP_Text cubeText;
    public int currentCubes = 0;

    public TMP_Text sphereText;
    public int currentSpheres = 0;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        cubeText.text = "Cube parts: " +  currentCubes.ToString() + " / 5";

        sphereText.text = "Sphere parts: " + currentSpheres.ToString() + " / 5";
    }

    public void IncreaseCubes(int v)
    {
        currentCubes += v;
        cubeText.text = "Cube parts: " + currentCubes.ToString() + " / 5";
            }

    public void IncreaseSpheres(int v)
    {
        currentSpheres += v;
        sphereText.text = "Sphere parts: " + currentSpheres.ToString() + " / 5";
    }


}
