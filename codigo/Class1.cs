using System;

public class Gramatica
{

    //Atributos\\

    //Reglas de la gramatica
    public List<Regla> reglas;

    //Representa todas las variables utilizadas.
    public List<char> variables;

    //terminales en la gramatica
    public List<char> terminales;

    //variables posibles
    public List<char> variablesPosibles = new List<char>(){ 'A','B','C', 'D', 'E','F','G','H','I','J','K','L','M',
                                                                'N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};

}
