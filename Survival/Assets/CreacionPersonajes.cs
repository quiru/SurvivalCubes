using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreacionPersonajes : MonoBehaviour
{
    public GameObject tipoPersonaje;
    //public Vector3 pos;
    string[] nombres;

    void Start()
    {
        nombres = new string[] { "octavio", "rosendo", "geremias", "evaristo", "rogelio", "leocadio", "ansizar", "marinela", "juaquina", "berta", "jacinta", "casemira", "eusebio", "ramona", "flavio", "celina", "reutilio", "lola", "celia", "condorito" };
        //GameObject personajePpal = GameObject.Instantiate(tipoPersonaje) as GameObject;
        //personajePpal.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        //pos = new Vector3(Random.Range(0, 100), 0.5f, Random.Range(0, 100));
        //personajePpal.transform.position = pos;
        PersPrinciapal personajePpal = new PersPrinciapal(tipoPersonaje);

        int numZombies = Random.Range(4, 10);
        for (int i = 0; i < numZombies; i++)
        {
            Zombie creaZombies = new Zombie();
            
        }

        int numPersonas = Random.Range(0, 10 - numZombies);
        for (int i = 0; i < numPersonas; i++)
        {
            int ponerNombre = Random.Range(0, 20);
            string nombrCiud = nombres[ponerNombre];
            ciudadano ciudadanos = new ciudadano(nombrCiud);
        }
    }

    
    void Update()
    {
        bool aKey = Input.GetKey(KeyCode.A);
        bool sKey = Input.GetKey(KeyCode.S);
        bool wKey = Input.GetKey(KeyCode.W);
        bool dKey = Input.GetKey(KeyCode.D);
        //transform.position = pos;
    }

    class PersPrinciapal
    {
        GameObject personajePpal;

        public PersPrinciapal(GameObject tipPers)
        {
            personajePpal = GameObject.Instantiate(tipPers) as GameObject;
            personajePpal.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            Vector3 pos = new Vector3(Random.Range(1, 100), 0.5f, Random.Range(1, 100));
            personajePpal.transform.position = pos;
            personajePpal.AddComponent<Camera>();
        }
    }

    class Zombie
    {
        public Zombie()
        {
            int cambioColor = Random.Range(1, 4);
            GameObject objZombie;
            Vector3 pos = new Vector3(Random.Range(1, 100), 0.5f, Random.Range(1, 100));

            switch (cambioColor)
            {
                case 1:
                    objZombie = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    objZombie.GetComponent<Renderer>().material.color = Color.cyan;
                    objZombie.transform.position = pos;
                    break;
                case 2:
                    objZombie = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    objZombie.transform.position = pos;
                    objZombie.GetComponent<Renderer>().material.color = Color.green;
                    break;
                case 3:
                    objZombie = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    objZombie.transform.position = pos;
                    objZombie.GetComponent<Renderer>().material.color = Color.magenta;
                    break;
            }
            print(DarMensaje(cambioColor));
        }
        string DarMensaje(int colorcito)
        {
            string mensaje = null;
            if (colorcito == 1)
            {
                mensaje = "soy un zombie de color cyan";
            }
            else if (colorcito == 2)
            {
                mensaje = "soy un zombie de color verde";
            }
            else if (colorcito == 3)
            {
                mensaje = "soy un zombie color magenta";
            }
            return mensaje;
        }
    }

    class ciudadano
    {
        int edad;
        GameObject objCiudadano;
        Vector3 pos = new Vector3(Random.Range(1, 100), 0.5f, Random.Range(1, 100));
        public ciudadano(string nombr)
        {
            objCiudadano = GameObject.CreatePrimitive(PrimitiveType.Cube);
            objCiudadano.transform.position = pos;
            objCiudadano.GetComponent<Renderer>().material.color = Color.blue;
            objCiudadano.name = nombr;
            edad = Random.Range(15, 101);
            print(DarMensaje(objCiudadano, edad));
        }
        string DarMensaje(GameObject ciudadano, int edd)
        {
            string cambioEdad = edd.ToString();
            string nombr = ciudadano.name;
            return "hola soy " + nombr + " y tengo " + cambioEdad + " años";
        }
    }
}
