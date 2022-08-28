//Vamos a usar el paquete del sistema
using System;
//Definimos la capa a utilizar
namespace Gym.App.Dominio
{
    public class Routine{
        //Definimos la funcionalidad de Propiedades, usando la
        //notacion Pascal (1mer caracter del atributo en Mayuscula)
         public BodyPart  BodyPart {get; set;}
         public Intensity Intensity {get; set;}
         public Category Category {get; set;}
        //Definimos las relaciones de ASOCIACION
        //Clase Routine --> Exercise 
        public Exercise Exercise {get; set;}           
    } 
}