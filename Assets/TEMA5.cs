/*Se pide que se ingrese por inspector:
. Los nombre de tres productos
. Los precios de cada producto
. La cantidad de unidades deseada de cada producto

El programa debe cumplir los siguientes requerimientos:

Debe calcularse un descuento del 20% sobre la compra de un producto si la cantidad de unidades del mismo supera las 3. 

El programa debe devolver un mensaje de error descriptivo si el precio del producto o la cantidad de unidades son menores a 1.

El programa debe devolver el total de la compra de los tres productos mostrando un mensaje que incluya el monto total sin descuento, el monto de los descuentos aplicados y el total con los descuentos aplicados.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEMA5 : MonoBehaviour
{
    public string Producto1, Producto2, Producto3;
    public float PrecioProducto1, PrecioProducto2, PrecioProducto3;
    public float CantidadProducto1, CantidadProducto2, CantidadProducto3;
    float descuento1;
    float descuento2;
    float descuento3;
    float montodescuento;
    float monto1;
    float monto2;
    float monto3;
    // Start is called before the first frame update
    void Start()
    {
        if (PrecioProducto1 < 1 || CantidadProducto1 < 1)
        {
            Debug.Log("El precio o la cantidad del producto no puede ser menor a 1");
        } else if (PrecioProducto2 < 1 || CantidadProducto2 < 1)
        {
            Debug.Log("El precio o la cantidad del producto no puede ser menor a 1");
         } else if (PrecioProducto3 < 1 || CantidadProducto3 < 1)
        {
            Debug.Log("El precio o la cantidad del producto no puede ser menor a 1");
        }
        else {
            monto1 = PrecioProducto1 * CantidadProducto1;
            monto2 = PrecioProducto2 * CantidadProducto2;
            monto3 = PrecioProducto3 * CantidadProducto3;
            
            if (CantidadProducto1 > 3)
            {
                descuento1 = (monto1 / 100) * 20;
         
            }
            if (CantidadProducto2 > 3)
            {
                descuento2 = (monto2 / 100) * 20;

            }
            if (CantidadProducto3 > 3)
            {
                descuento3 = (monto3 / 100) * 20;
            }
        }
        montodescuento = (monto1 - descuento1) + (monto2 - descuento2) + (monto3 - descuento3);
        Debug.Log("El monto total de la compra es $" + (monto1 + monto2 + monto3));
        Debug.Log("El monto de los descuentos aplicados es $" + (descuento1 + descuento2 + descuento3));
        Debug.Log("El monto total con el descuento es $" + montodescuento);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
