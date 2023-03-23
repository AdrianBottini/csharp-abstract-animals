using csharp_abstract_animals.Animali;

var cane = new Cane();
var passerotto = new Passerotto();
var aquila = new Aquila();
var delfino = new Delfino();

cane.Mangia();
passerotto.Dormi();
aquila.Verso();
delfino.Verso();

FaiNuotare(delfino);
FaiVolare(aquila);

void FaiVolare(IVola animale)
{
    animale.Vola();
}

void FaiNuotare(INuota animale)
{
    animale.Nuota();
}