# Funkcionális specifikáció

## 1. Felhasználói felület
- Ablak, amely tartalmaz:
  - Számgombokat (0–9).
  - Műveleti gombokat (+, –, ×, ÷).
  - Eredmény gombot (=).
  - Törlés gombot (C/CE).
  - Kijelző mezőt (TextBox vagy Label).

## 2. Folyamatok
1. Felhasználó számot ad meg → megjelenik a kijelzőn.
2. Felhasználó kiválaszt egy műveletet → program eltárolja az első operandust és a műveletet.
3. Második szám megadása.
4. `=` gomb megnyomásakor a program kiszámítja és kiírja az eredményt.
5. `C` gomb törli a kijelzőt.

## 3. Használati esetek
- **Számítás végrehajtása**: számok + művelet + = → eredmény kijelzőn.
- **Hibás bemenet kezelése**: pl. nullával osztás → „Hiba: nullával nem lehet osztani”.
