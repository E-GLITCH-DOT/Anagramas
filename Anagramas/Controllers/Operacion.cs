using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagramas.Controllers
{
    /*Nombre de la escuela: Universidad Tecnologica Metropolitana
    Asignatura: Aplicaciones Web Orientadas a Servicios
    Nombre del Maestro: Chuc Uc Joel Ivan
    Nombre de la actividad: Actividad 1, Ejercicio 2: Palíndromos
    Nombre del alumno: Eduardo Emanuel Herrera 
    Cuatrimestre: 4
    Grupo: C
    Parcial: 1
    */

    [Route("api/[controller]")]
    [ApiController]
    public class Operacion : ControllerBase
    {
        [HttpGet]
        public IActionResult Anagrama(string palabra1, string palabra2)
        {
            bool anagrama;
            var RoT = "";
            if (palabra1.Length != palabra2.Length)
            {
                anagrama = false;
            }
            else
            {
                char[] letras1 = palabra1.ToCharArray();
                Array.Sort(letras1);
                char[] letras2 = palabra2.ToCharArray();
                Array.Sort(letras2);
                

                string pal = new string(letras1);
                string pal2 = new string(letras2);
                if (pal == pal2)
                {
                    anagrama = true;
                }
                else
                {
                    anagrama = false;
                }
            }
            if (anagrama == true)
            {
                RoT = "Las palabras " + palabra1 + " y " + palabra2 + " Son Anagramas";
            }
            else
            {
                RoT = "Las palabras " + palabra1 + " y " + palabra2 + " No son Anagramas";
            }
            return Ok(RoT);
        }
    }
}
