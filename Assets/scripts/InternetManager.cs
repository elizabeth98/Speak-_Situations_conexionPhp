using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InternetManager : MonoBehaviour
{

    public Text checkInternet;
    private string urlData = "http://tadeolabhack.com:8081/test/Datos/isConection.php";
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_checkInternet());
    }
    public IEnumerator _checkInternet(){
        WWW getData = new WWW(urlData);
        yield return getData;

        print(getData.text);

        if (getData.text == "ConexionEstablecida")
        {
            checkInternet.text = "Conexion establecida";
        }

        else {

            checkInternet.text = "Sin conexion";
        }

}
    // Update is called once per frame
   
}
