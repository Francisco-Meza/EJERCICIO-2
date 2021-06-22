
//----------------------- CLASE DERIVADA -----------------------------------
class Cadenas: ICadenas
    //-------------- ATRIBUTOS ------------------------------------
{
    char[] charArr;
    string cadena;
    //-------------- CONSTRUCTOR ----------------------------------
    public Cadenas(char[] cadena)
    {
        CharArr = cadena;
    }
    //------------- PROPIEDADES -------------------------------------
    public char[] CharArr { get => charArr; set => charArr = value; }
    public string Cadena { get => cadena; set => cadena = value; }
    //------------- METODOS ----------------------------------------
    public string Mayusculas()//DEVULEVE LA CADENA EN MAYUSCULAS
    {
        string ans = "";
        foreach(char c in CharArr)//-- RECORRE EL ARREGLO Y LO AGREGA A CADENA
        {
            ans += char.ToUpper(c)+"\n";
        }
        return ans;
    }

    public string Reversa()
    {
        string ans = "";
        for (int i = CharArr.Length-1; i != -1; i--)//-- RECORRE EL ARREGLO DE REVERSA Y LO VA GUARDANDO
        {
            ans += CharArr[i] + "\n";
        }
        return ans;
    }

    public char[] Sustitucion()
    {
        for(int i = 0; i < CharArr.Length; i++)//-- RECORRE EL ARREGLO
        {
            switch (CharArr[i])//-- EVALUA EL CARACTER PARA SUSTITUIR
            {
                case 'A': CharArr[i] = '4'; break;
                case 'I': CharArr[i] = '1'; break;
                case 'S': CharArr[i] = '5'; break;
                case 'B': CharArr[i] = '8'; break;
                case 'E': CharArr[i] = '3'; break;
                case 'T': CharArr[i] = '7'; break;
            }
        }
        return CharArr;
    }
}
