using Ludiq;
using Bolt;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample_Call2Bolt : MonoBehaviour {

    //void Start() {
    //}

    void Update() {
        GameObject boltObject = GameObject.Find("Bolt_Object");
        if (boltObject != null) {
            /*  CustomEvent.Trigger( GameObject target, string name [, params object[] args [, ...] ])
             *     target: GameObject that is in Bolt Graph(Flow / State)
             *     name: Custom Event define name.
             *     args: Argment.
            */
            CustomEvent.Trigger(boltObject, "OnFlow",1);    // Call CustomEvent "OnFlow" in Flow Graph.
            CustomEvent.Trigger(boltObject, "OnState",10);  // Call CustomEvent "OnStateMachine" in Flow Graph.
        }
    }
}
