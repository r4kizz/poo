Console.WriteLine("=== INICIO DE LA BATALLA ===\n");
Guerrero arthur = new Guerrero("Arthur el Valiente", 100, 15, 10);
Mago merlin = new Mago("Merlin el sabio", 70, 5, 20);

int ronda = 1;
// bucle del combate
while (arthur.Vida > 0 && merlin.Vida > 0);
{
    Console.WriteLine($"--- RONDA {ronda} ---");
    //turno 1
    arthur.Atacar(merlin);
    //condicion de quiebre para evitar ataques de un personaje derrotado
    if (merlin.Vida <= 0) break;
    //turno 2
    merlin.Atacar(arthur);
    ronda++;
    Console.WriteLine("Presiona ENTER para la siguiente ronda...\n");
    Console.ReadLine();
}
Console.WriteLine("=== FIN DE LA BATALLA ===\n");
//resolucion
if ( arthur.Vida > 0)
    Console.WriteLine($"¡{arthur.Nombre} es el vencedor!");
else
    Console.WriteLine($"¡{merlin.Nombre} es el vencedor!");