using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.
Comunicar si la suma de los mismos supera o no el monto de dinero disponible.Luego indicar cuánto dinero sobra o falta.*/

public class Ejercicio2 : MonoBehaviour
{
    /* Si me piden el %20 del total
     * total * 0,8 = precio con descuento 
     20 * total / 100 */
    public float producto1;
    public float producto2;
    public float producto3;
    public float montoDisponible;
    // Start is called before the first frame update
    void Start()
    {
        float productos = producto1 + producto2 + producto3;
        if (productos == montoDisponible)
        {
            Debug.Log("La suma de los tres productos es igual al monto disponible");
        }
        else if (productos > montoDisponible)
        {
            Debug.Log("La suma de los tres productos supera al monto disponible. Le faltan $" + (productos - montoDisponible));
        }
        else
        {
            Debug.Log("La suma de los tres productos no supera al monto disponible. Le sobran $" + (montoDisponible - productos));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
