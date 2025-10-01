# Rendszerterv

## 1. Architektúra
- Egyrétegű alkalmazás.
- GUI és logika egy projektben.
- Nyelv: C# (.NET, WinForms/WPF).

## 2. Modulok
- **UI modul**: gombok, kijelző, események.
- **Számítási modul**:
  - `Add(a, b)`
  - `Subtract(a, b)`
  - `Multiply(a, b)`
  - `Divide(a, b)` → hibakezeléssel.

## 3. Adatszerkezetek
- `double` vagy `decimal` típus a számokhoz.
- Változók:
  - aktuális érték
  - előző érték
  - kiválasztott művelet

## 4. Hibakezelés
- Nullával való osztás figyelése.
- Nem értelmezhető bevitel esetén hibaüzenet.

## 5. Tesztelési terv
- Egyszerű műveletek: 2+2=4, 5–3=2, 4×3=12, 8÷2=4.
- Szélső esetek: nagy számok, többjegyű számok, tizedesek.
- Hibás eset: 5÷0 → hibaüzenet.
