using System;

public class ScrapperClima
{
    List<String> ahora = new List<String>();
    List<String> nombre = new List<String>();
    List<String> condensacion = new List<String>();
    List<String> sensacion = new List<String>();
    List<String> hoy = new List<String>();


    public String extraer(String entrada, String param1, String param2)
    {
        Kuto extraer = new Kuto(entrada);
        return extraer.Extract(param1, param2).ToString();
    }
    public List<String> hoy_ahora()
    {
        return hoy;
    }
    public List<String> sensacion_ahora()
    {
        return sensacion;
    }
    public List<String> datos_ahora()
    {
        return ahora;
    }
    public List<String> nombre_ahora()
    {
        return nombre;
    }
    public List<String> condensacion_nom()
    {
        return condensacion;
    }


    public void obtenerdatos2()
    {
        HtmlWeb web = new HtmlWeb();
        HtmlAgilityPack.HtmlDocument doc = web.Load("https://weather.com/es-MX/tiempo/hoy/l/22.74,-98.96?par=google&temp=c");
        var body = doc.DocumentNode.CssSelect("table").First();

        foreach (var nodo in body.CssSelect("tr"))
        {
            nombre.Add(nodo.CssSelect("span").First().InnerHtml);

            String aux = "";
            aux = nodo.CssSelect("span").First().InnerHtml;
            ahora.Add(extraer(aux, "", "<"));
        }
        foreach (var nodo in body.CssSelect("tr"))
        {
            String aux = "";
            aux = nodo.CssSelect("span").First().InnerHtml;
            condensacion.Add(extraer(aux, "<span>", "<"));
        }


        //traer sensacion termina
        var body2 = doc.DocumentNode.CssSelect("div").First();
        foreach (var nodo in body2.CssSelect(".today_nowcard-feels"))
        {
            String aux = "";
            aux = nodo.CssSelect(".deg-feels").First().InnerHtml;
            sensacion.Add(extraer(aux, "", "<"));
        }
        //traer clima hoy
        foreach (var nodo in body2.CssSelect(".today_nowcard-temp"))
        {
            String aux = "";
            aux = nodo.CssSelect("span").First().InnerHtml;
            hoy.Add(extraer(aux, "", "<"));
        }



    }


    List<String> descripcion = new List<String>();
    List<String> temperatura = new List<String>();
    List<String> precipitacion = new List<String>();
    List<String> humedad = new List<String>();
    List<String> viento = new List<String>();

    public List<String> datos_descripcion()
    {
        return descripcion;
    }
    public List<String> datos_temperatura()
    {
        return temperatura;
    }
    public List<String> datos_precipitacion()
    {
        return precipitacion;
    }
    public List<String> datos_humedad()
    {
        return humedad;
    }
    public List<String> datos_viento()
    {
        return viento;
    }
    public void obtenerdatos5dias()
    {
        HtmlWeb web = new HtmlWeb();
        HtmlAgilityPack.HtmlDocument doc = web.Load("https://weather.com/es-MX/tiempo/5dias/l/bf33f5f6cf94548d17252c0a66691d38ca21372020aa79528c76ed9eabaf3686");

        var body = doc.DocumentNode.CssSelect(".twc-table").First();

        foreach (var nodo in body.CssSelect("tr"))
        {
            String aux = "";
            aux = nodo.CssSelect(".description").First().InnerHtml;
            descripcion.Add(extraer(aux, ">", "<"));
            //MessageBox.Show("descripcion " +extraer(aux,">","<"));

            aux = nodo.CssSelect(".precip").First().InnerHtml;
            aux = extraer(aux, "</span><span", "");
            // MessageBox.Show("precipitacion " +extraer(aux,"<span>","<"));
            precipitacion.Add(extraer(aux, "<span>", "<"));
            aux = nodo.CssSelect(".wind").First().InnerHtml;
            viento.Add(extraer(aux, ">", "<"));
            //  MessageBox.Show("viento " + extraer(aux,">","<"));
            aux = nodo.CssSelect(".humidity").First().InnerHtml;
            humedad.Add(extraer(aux, "<span>", "<"));
            // MessageBox.Show("humedad " + extraer(aux,"<span>","<"));
            aux = nodo.CssSelect(".temp").First().InnerHtml;
            aux = extraer(aux, "span", "");
            String tem1 = extraer(aux, ">", "<") + "°";
            aux = extraer(aux, "classname", "");
            aux = extraer(aux, "</span><span", "");
            temperatura.Add(tem1 + "/" + extraer(aux, ">", "<") + "°");
            //MessageBox.Show("temperatura " + tem1+"/"+extraer(aux,">","<")+ "°");

        }


    }
}
