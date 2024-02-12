using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnifyingLens : MonoBehaviour
{
    public Transform MainCamera; // Assignez votre MainCamera ici dans l'éditeur Unity

    private new Camera camera;

    // Utilisez cette méthode pour l'initialisation
    void Start()
    {
        // Obtenez le composant Camera attaché à un enfant de cet objet
        camera = GetComponent<Camera>();
    }

    // Mettre à jour est appelé une fois par image
    void Update()
    {
        // Faites en sorte que la "camera" regarde toujours vers la "MainCamera"
        camera.transform.rotation = MainCamera.rotation;
    }
}
