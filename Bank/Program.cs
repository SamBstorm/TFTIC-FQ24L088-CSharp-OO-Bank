﻿using Bank.entities;

Console.OutputEncoding = System.Text.Encoding.Unicode;

Personne personne1 = new Personne(
        "John",
        "Doe",
        new DateTime(2024, 12, 23) //DateTime.Now ajd
    );

Personne thierry = new Personne(
        "Thierry",
        "Morre",
        new DateTime(2024, 12, 23) //DateTime.Now ajd
    );

Banque banque = new Banque();

Courant compteDeJohn = new Courant(
    personne1,
    "BEX 1234 1234 1234 123 123 123 123 123 123",
    3432,
    0
    );

Courant compteDeThierry = new Courant(
    thierry,
    "BE12 34",
    -50,
    100
    );

Epargne compteDeThierry2 = new Epargne() { Numero = "BE22 34", Titulaire = thierry };

banque.Ajouter(compteDeJohn);
banque.Ajouter(compteDeThierry);
banque.Ajouter(compteDeThierry2);

compteDeThierry2.Depot(5000);

Console.WriteLine(banque["BEX 12ezae"]);

//Console.WriteLine($"La totalité des soldes positifs des comptes de Thierry est de {compteDeThierry + compteDeThierry2} €.");
Console.WriteLine($"La totalité des soldes positifs des comptes de Thierry est de {banque.AvoirDesComptes(thierry)} €.");

