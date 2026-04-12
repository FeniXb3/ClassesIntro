namespace ClassesIntro;

public class Player
{
    /*
     * Akcje:
     * - poruszanie się
     * - wyświetlanie swojego awatara
     * - podnoszenie przedmiotów
     * - zarządzanie ekwipunkiem
     * - otrzymywanie obrażeń
     * - atak
     * - rozmowa z NPC
     * - podejmowanie i wykonywanie zadań
     *
     * Dane:
     * - pozycja
     * - prędkość poruszania się
     * - awatar (reprezentacja graficzna gracza)
     * - zasięg interakcji
     * - ekwipunek (sposób przechowania go)
     * - hp (aktualne, maskymalne, określające jakieś ograniczenia ruchu?)
     * - siła ataku
     * - zasięg ataku
     * - częstotliwość ataku
     * - celność
     * - info czy z kimś rozmawialiśmy
     * - dziennik
     * - lista zadań ze statusem ich realizacji
     */
    private string avatar = "@";
    private int x;
    private int y;

    public void Display()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(avatar);
    }

    public void ClearAtPosition()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(" ");
    }

    public void Move(int diffX, int diffY)
    {
        x += diffX;
        y += diffY;
    }
}