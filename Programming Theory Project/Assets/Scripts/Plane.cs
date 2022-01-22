using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : Shape { // INHERITANCE

    void Awake() {
        Name = "Plane"; // ENCAPSULATION
    }

    protected override void Rotate() { // POLYMORPHISM
        transform.Rotate(Vector3.right * speed * Time.deltaTime);
    }

}
