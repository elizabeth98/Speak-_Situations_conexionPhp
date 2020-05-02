using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class userDataa : MonoBehaviour
{
    private string getUrlEscribir = "http://tadeolabhack.com:8081/test/Datos/speakingPhp/escribir.php";

    private string nombre = " ";
    private string contras = " ";
    private string correo = " ";

    public Text rellenarCampos;
    public Text registroExitoso;
    public GameObject confirmación;

    public InputField campoNombre;
    public InputField campoContra;
    public InputField campoCorreo;

    public void SenData()
    {

        StartCoroutine(enviarDatosUsuario());

    }
    private IEnumerator enviarDatosUsuario()
    {
        nombre = campoNombre.text;
        contras = campoContra.text;
        correo = campoCorreo.text;



        if (nombre == "" || contras == "" || correo == "")
        {
            rellenarCampos.text ="*Debes llenar todos los campos";

        }

        else {
            


            WWWForm form = new WWWForm();
            form.AddField("nom", nombre);
            form.AddField("contra", contras);
            form.AddField("co", correo);

            WWW retroalimentacion = new WWW(getUrlEscribir, form);
            yield return retroalimentacion;

            print(retroalimentacion.text);

            confirmación.SetActive(true);
            registroExitoso.text="Has sido registrado \n exitosamente";
            print(nombre + "" + contras + "" + correo + "");
            

        }


           //Si tengo un dato tipo int:
        // edad = int.Parse(CampoEdad.text);








    }
}
