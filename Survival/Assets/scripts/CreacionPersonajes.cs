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
        nombres = new string[] { "octavio", "rosendo", "geremias", "evaristo", "rogelio", "leocadio", "ansizar", "marinela", "juaquina", "berta", "jacinta", "casemira", "eusebio", "ramona", "flavio", "celina", "reutilio", "lola", "celia", "condorito" }; //para dar nombre a los ciudadanos
        
        PersPrinciapal personajePpal = new PersPrinciapal(tipoPersonaje);

        int numZombies = Random.Range(4, 10);
        for (int i = 0; i < numZombies; i++) //para crear los zombies
        {
            Zombie creaZombies = new Zombie();
            
        }

        int numPersonas = Random.Range(0, 10 - numZombies);
        for (int i = 0; i < numPersonas; i++) //para crear los ciudadanos
        {
            int ponerNombre = Random.Range(0, 20);
            string nombrCiud = nombres[ponerNombre];
            ciudadano ciudadanos = new ciudadano(nombrCiud);
        }
    }

    

    class PersPrinciapal //clase para la creacion del heroe
    {
        GameObject personajePpal;

        public PersPrinciapal(GameObject tipPers) //constructor de clase
        {
            personajePpal = GameObject.Instantiate(tipPers) as GameObject;
            personajePpal.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            Vector3 pos = new Vector3(Random.Range(1, 100), 0.5f, Random.Range(1, 100));
            personajePpal.transform.position = pos;
            personajePpal.AddComponent<Camera>();
        }
    }

    class Zombie //clase para la creacion de zombies
    {
        public Zombie() //constructor de clase 
        {
            int cambioColor = Random.Range(1, 4);
            GameObject objZombie;
            Vector3 pos = new Vector3(Random.Range(1, 100), 0.5f, Random.Range(1, 100));

            switch (cambioColor) //switch para dar color al zombie segun variable cambioColor
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
            print(DarMensaje(cambioColor)); // llama funcion para dar mensaje
        }
        string DarMensaje(int colorcito) //funcion para mostrar mensaje
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

    class ciudadano //clase para creacion de ciudadanos
    {
        int edad;
        GameObject objCiudadano;
        Vector3 pos = new Vector3(Random.Range(1, 100), 0.5f, Random.Range(1, 100));
        public ciudadano(string nombr) //constructor de clase
        {
            objCiudadano = GameObject.CreatePrimitive(PrimitiveType.Cube);
            objCiudadano.transform.position = pos;
            objCiudadano.GetComponent<Renderer>().material.color = Color.blue;
            objCiudadano.name = nombr;
            edad = Random.Range(15, 101);
            print(DarMensaje(objCiudadano, edad)); //llama funcion para dar mensaje
        }
        string DarMensaje(GameObject ciudadano, int edd) //funcion para mostrar mensaje
        {
            string cambioEdad = edd.ToString();
            string nombr = ciudadano.name;
            return "hola soy " + nombr + " y tengo " + cambioEdad + " años";
        }
    }
}
