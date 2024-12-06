Console.Write("Quelle est la taille de ta flêche (nombre entre 0 et 57) ? ");
var sizestring = Console.ReadLine();
int sizeint;
sizeint = Convert.ToInt32(sizestring);
int line = 1;
int gap = 1;
int espace;
espace = sizeint - 1;
int chang = 1;
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
while (chang == 1){
    while (line != sizeint - 1){
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
        chang = 2;
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