using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class infoPartida : MonoBehaviour
{

    private string getUrlEscribirResultados = "http://tadeolabhack.com:8081/test/Datos/speakingPhp/escribirDatosPartid.php";

    public int idUsuario_FK=5;
    private int numErrores=0;
    private int numAciertos=0;

    public GameObject pestanaGanar;

    public static int contadorCorrectas;
    public static int contadorIncorrectas;

    void Update() {
        


        print("Correcto:"+contadorCorrectas+"Incorrecto: "+contadorIncorrectas);
        

    }




    // Start is called before the first frame update
    public void SenData()
    {

        StartCoroutine(enviarDatosPartida());
        
      
}


    private IEnumerator enviarDatosPartida()
    {

        numAciertos = contadorCorrectas;
        numErrores = contadorIncorrectas;

        WWWForm form = new WWWForm();
        form.AddField("idUS", idUsuario_FK);
        form.AddField("numE", numAciertos);
        form.AddField("numA", numErrores);

        WWW retroalimentacion = new WWW(getUrlEscribirResultados, form);
        yield return retroalimentacion;

        print(retroalimentacion.text);
        pestanaGanar.SetActive(true);

        print(idUsuario_FK + " " + numErrores + " " + numAciertos + " ");

        

    }
}
