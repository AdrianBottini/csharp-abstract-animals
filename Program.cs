using csharp_abstract_animals.Animali;

var cane = new Cane();
var passerotto = new Passerotto();
var aquila = new Aquila();
var delfino = new Delfino();
var pulcinella = new PulcinellaDiMare();

cane.Mangia();
passerotto.Dormi();
aquila.Verso();
delfino.Verso();

FaiNuotare(delfino);
FaiVolare(aquila);
FaiNuotare(pulcinella);
FaiVolare(pulcinella);

void FaiVolare(IVola animale)
{
    animale.Vola();
}

void FaiNuotare(INuota animale)
{
    animale.Nuota();
}