Console.Write("Veuillez entrez un nombre entier entre 2 et 20 : ");
var sizestring = Console.ReadLine();
if (!int.TryParse(sizestring, out _))
{
    Console.WriteLine("Votre nombre doit être un entier.");
    return;
}
int sizeint;
sizeint = Convert.ToInt32(sizestring);
if (sizeint < 2){
    Console.Write("Erreur, Veuillez écrire un nombre entre 2 et 20.");
    Console.Write("\n");
    return;
}
if (sizeint > 20){
    Console.Write("Erreur, Veuillez écrire un nombre entre 2 et 20.");
    Console.Write("\n");
    return;
}

int line = 1;
int gap = 1;
int espace;
espace = sizeint - 1;
int queufleche = sizeint - 1;

if (sizeint == 0){
    return;
}
if (sizeint == 1){
    Console.Write("*");
    Console.Write("\n");
    return;
}
for (int i = 0; i < espace + 1; i++){
        Console.Write(" ");
}
Console.Write("*");
Console.Write("\n");

for (int n = 0; n < sizeint - 2; n++){
    for (int i = 0; i < espace; i++){
            Console.Write(" ");
        }
    espace--;
    Console.Write("*");
    for (int i = 0; i < gap; i++){
        Console.Write(" ");
    }
    Console.Write("*");
    gap = gap + 2;
    line++;
    Console.Write("\n");
}

Console.Write(" ");
for (int i = 0; i < sizeint * 2 - 1; i++){
    Console.Write("*");
}
Console.Write("\n");
for (int i = 0; i < sizeint; i++){
    for (int n = 0; n < sizeint; n++){
        Console.Write(" ");
    }
    Console.Write("*");
    Console.Write("\n");
}