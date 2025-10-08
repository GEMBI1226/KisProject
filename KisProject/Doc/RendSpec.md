# Rendszerterv – Számológép Projekt

## 1. A rendszer célja
A rendszer célja egy **modern megjelenésű, egyszerűen használható számológép** alkalmazás fejlesztése Windows környezetre.  
A program az alapvető aritmetikai műveletek (összeadás, kivonás, szorzás, osztás) elvégzésére szolgál, és célja a hagyományos, elavult dizájn lecserélése egy **letisztult, iPhone-stílusú grafikus felületre**, amely vizuálisan is illeszkedik a modern számítógépes rendszerekhez.

---

## 2. A rendszer környezete

| Elem | Leírás |
|------|--------|
| **Fejlesztési környezet** | Microsoft Visual Studio 2022 (vagy újabb) |
| **Programozási nyelv** | C# |
| **Technológia** | .NET Framework / Windows Forms |
| **Operációs rendszer** | Windows 10 / 11 |
| **Felhasználói célcsoport** | Általános felhasználók, akik egyszerű számológépre vágynak PC-n |
| **Hardverkövetelmény** | Alacsony (bármely korszerű számítógépen futtatható) |

---

## 3. A rendszer logikai felépítése

A rendszer fő moduljai:

### 🖥️ Felhasználói felület (UI)
- Megjeleníti a gombokat (0–9, +, –, ×, ÷, =, C, CE).  
- Tartalmazza a kijelző mezőt, ahol a beírt számok és az eredmény megjelennek.  
- Kezeli a felhasználói interakciókat (gombnyomások).

### ⚙️ Logikai vezérlő
- Összegyűjti és értelmezi a gombnyomásokat.  
- Eldönti, mikor kell műveletet végrehajtani.  
- Továbbítja az adatokat a számítási modulnak.

### 🔢 Számítási modul
- Végrehajtja a műveleteket: +, –, ×, ÷.  
- Kezeli a hibás műveleteket (pl. 0-val osztás).  
- Eredményt ad vissza a felhasználói felület számára.

### 🚫 Hibakezelő modul
- Ellenőrzi az érvénytelen műveleteket.  
- Felhasználóbarát üzeneteket jelenít meg (pl. “Syntax error”).

---

## 4. Adatáramlási modell

**Adatáramlás folyamata:**

Felhasználó → UI → Logikai vezérlő → Számítási modul → Eredmény → UI kijelző

yaml
Kód másolása

**Lépések:**
1. A felhasználó megnyom egy gombot (pl. “7”).  
2. A UI modul elküldi a vezérlőnek, hogy számbevitel történt.  
3. A vezérlő rögzíti az értéket, és ha szükséges, továbbítja a számítási modulnak.  
4. A számítási modul elvégzi az adott műveletet.  
5. Az eredmény visszakerül a felhasználói felületre, és megjelenik a kijelzőn.

---

## 5. Felhasználói felület terve

### 🎨 Dizájn jellemzői
- Letisztult, **iPhone-stílusú kinézet**.  
- Lekerekített gombok, árnyékolt hatások.  
- Modern színpaletta (kontrasztos gombok).  
- Jól olvasható, nagy méretű kijelző.

---

## 6. Főbb folyamatok leírása

### 6.1. Összeadás folyamata
1. Felhasználó megnyomja az első számot (pl. **5**).  
2. Kiválasztja a **„+”** gombot.  
3. Beírja a második számot (pl. **3**).  
4. Megnyomja az **„=”** gombot.  
5. A számítási modul elvégzi: `5 + 3 = 8`.  
6. Az eredmény megjelenik a kijelzőn.

### 6.2. Hiba eset (0-val osztás)
1. Felhasználó beírja: **8 ÷ 0**.  
2. A számítási modul felismeri a hibát.  
3. Hibaüzenet jelenik meg: **“Syntax error”**.  
4. A kijelző törlődik, új számítás kezdhető.

---

## 7. Hibakezelés
- Érvénytelen bevitel (pl. egymás utáni operátor) esetén a program **nem hajt végre műveletet**.  
- **0-val való osztás** esetén a program leállítja a számítást, és **hibaüzenetet** jelenít meg.  
- A **“C”** gomb törli az összes tárolt adatot és visszaállítja az alapállapotot.  
- A **“CE”** gomb csak az aktuális bevitelt törli.

---

## 8. Tesztelési terv (röviden)

| Teszt esete | Bemenet | Elvárt kimenet |
|--------------|----------|----------------|
| Összeadás | 5 + 3 = | 8 |
| Kivonás | 9 – 4 = | 5 |
| Szorzás | 6 × 2 = | 12 |
| Osztás | 8 ÷ 2 = | 4 |
| 0-val osztás | 7 ÷ 0 = | Hibaüzenet |
| Törlés | C | Kijelző törlődik |

---

## 9. Fejlesztési korlátok és jövőbeli bővítések

### 🔒 Korlátok
- Csak alapműveletek támogatottak.  
- Nem tartalmaz tudományos funkciókat.  
- Kizárólag Windows rendszeren fut.

### 🚀 Jövőbeli bővítések
- Tudományos mód (sin, cos, √ stb.).  
- Memóriafunkciók (M+, M–, MR).  
- Téma- és színválasztási lehetőség.  
- Mobil verzió fejlesztése (Android, iOS).

---

## 10. Összegzés
A rendszer **egyszerű, de korszerű megoldást** kínál az alapvető matematikai műveletek elvégzésére egy **modern, letisztult grafikus környezetben**.  
A fejlesztés során kiemelt szempont a **felhasználóbarát kezelhetőség**, a **hibamentes működés**, valamint a **dizájn és funkcionalitás egyensúlya**.

---
