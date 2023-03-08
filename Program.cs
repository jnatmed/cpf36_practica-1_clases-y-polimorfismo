using System;
using MyApp;
public class SampleArray{
    public static void Main(){
        String[] miArregloString = new String[5]{"1","2","3","4","5"};
        Object[] miArregloObj = new Object[5]{26,27,28,29,30};
        List<String> vocales = new List<String>() {"a", "b", "c", "d", "e", "f"};
        // List<Object> listComponentes = new List<Object>{miArregloObj, miArregloString,vocales};

        PrintValues(miArregloObj);
        PrintValues(miArregloString);
        PrintValues(vocales);
   }
   public static void PrintValues(String[] miArreglo){

        miArreglo[0] = "A";
        foreach (Object obj in miArreglo)
        {
            Console.Write("\t{0}", obj);
        }
        Console.WriteLine();
   }
   public static void PrintValues(Object[] miArreglo){
    Object addObj = new Object(){};
    miArreglo.Append(addObj);
        foreach (int i in miArreglo)
        {   
            String s = new String("_");
            Console.Write("\t" + i + "|" + s);
        }
        Console.WriteLine();
   }
   public static void PrintValues(List<string> miLista){
        foreach (var item in miLista)
        {
            Console.Write("\t" + item);            
        } 
        Console.WriteLine();
   }
}