public class operadores
{
    public static void Main (string [] args) {
        //operadores aritmeticos
    int adicao = 5 + 3;
    int subtracao = 5 + 3;
    int multiplicacao = 5 * 3;
    int divisao = 8 / 2;

    int expr = (1 + 2) * 5 - 2 / 2;
    
    //operadores relacionais
    int cidade1 = "Nova Iguaçu"
    int cidade2 = "Belford Roxo"

    bool ret1 = cidade1 == cidade2;
    bool ret2 = cidade1 != cidade2;

    int i = 2;
    int j = 5;

    bool ret3 = i == j;
    bool ret4 = i != j;
    bool ret5 = i > j;
    bool ret6 = i >= j;
    bool ret7 = i < j;
    bool ret8 = i !< j;

    //operadores logicos
    bool ret9 = i < j && cidade1 == cidade2;

    Console.WriteLine(ret9);
    }

}