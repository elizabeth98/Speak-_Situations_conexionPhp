using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class userInfo : MonoBehaviour
{

    private string UrlInfo = "http://tadeolabhack.com:8081/test/Datos/speakingPhp/mostrarNombreXUsuario.php";
    public Text txtDatos;
    public int idUser = 5;
    public GameObject pestanaPerfil;



    // Start is called before the first frame update
    public void obtenerInfo() {

        StartCoroutine(datos());
    }

    public IEnumerator datos() {
    

    string info = UrlInfo +"?IDuser="+idUser;

        WWW resultadoInfo = new WWW(info);

        yield return resultadoInfo;

        print(resultadoInfo.text);

        pestanaPerfil.SetActive(true);


        txtDatos.text = resultadoInfo.text;
        


}

}
