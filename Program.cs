namespace AS2627._3F.MarioBuononato.Punti2;

class Program
{
    static void Main(string[] args)
    {
        int importoLordo,sconto,importoNetto,pSconto;
        int punti;
        string giorno;
        Console.WriteLine("Quanto hai speso: ");
        importoLordo=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Che giorno è oggi? \n");
        giorno=Console.ReadLine();
        
        if (importoLordo <= 10) pSconto = 1;

        else if (importoLordo > 10 && importoLordo <= 50) pSconto = 3;

        else if (importoLordo > 50 && importoLordo <= 100) pSconto = 5;

        else pSconto = 7;

        sconto = importoLordo*(pSconto/100);
        importoNetto = importoLordo-sconto;

        punti = (int)(importoNetto/10);

        if (giorno.ToLower() == "mercoledì") punti=punti*2
        Console.WriteLine($"Hai speso per un totale di: {importoNetto}, con uno sconto di: {pSconto}%")
        Console.WriteLine($"I punti che hai guadagnato {punti}")

    }
}
