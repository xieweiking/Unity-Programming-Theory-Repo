using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Shape : MonoBehaviour {

    [SerializeField]
    protected float speed = 30; // ENCAPSULATION

    [SerializeField]
    Text titleText; // ENCAPSULATION
    [SerializeField]
    Color color = Color.white; // ENCAPSULATION

    public string Name { get; protected set; } // ENCAPSULATION

    // Start is called before the first frame update
    void Start() { // ABSTRACTION
        GetComponent<Renderer>().material.color = color;
    }

    // Update is called once per frame
    void Update() { // ABSTRACTION
        Rotate();
    }

    void OnMouseDown() { // ABSTRACTION
        Debug.Log(Name);
        titleText.text = $"Hi, I'm a {Name}!";
    }

    protected virtual void Rotate() {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }

}
