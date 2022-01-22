using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape { // INHERITANCE

    void Awake() {
        Name = "Capsule"; // ENCAPSULATION
    }

    protected override void Rotate() { // POLYMORPHISM
        transform.Rotate(new Vector3(0, 1, 1) * speed * Time.deltaTime);
    }

}
