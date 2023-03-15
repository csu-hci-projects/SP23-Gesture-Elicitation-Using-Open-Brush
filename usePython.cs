using UnityEngine;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

public class PythonScript : MonoBehaviour {

    void Start () {
        var engine = Python.CreateEngine();
        var scope = engine.CreateScope();
        var source = engine.CreateScriptSourceFromFile(".");
        source.Execute(scope);
    }

}