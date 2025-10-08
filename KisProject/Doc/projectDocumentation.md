# Funkcionális specifikáció – Számológép Projekt

## 1. A rendszer célja
A program célja egy modern megjelenésű, felhasználóbarát számológép létrehozása Windows környezetre.  
A rendszer biztosítja az alapvető aritmetikai műveletek gyors és egyszerű elvégzését egy letisztult, **iPhone-stílusú grafikus felületen** keresztül.

---

## 2. A rendszer funkciói

### 2.1. Számbevitel
- A felhasználó a grafikus felületen található **0–9 gombokkal** vihet be számokat.  
- Többjegyű szám beírása a gombok egymás utáni megnyomásával történik.  
- A bevitt szám azonnal megjelenik a kijelzőn.

### 2.2. Alapműveletek
A program az alábbi alapműveleteket támogatja:
- Összeadás (+)  
- Kivonás (–)  
- Szorzás (×)  
- Osztás (÷)

### 2.3. Eredménykijelzés
- Az **= (egyenlőség)** gomb megnyomásakor a program kiszámítja a művelet eredményét, és megjeleníti a kijelzőn.  
- Az eredmény további műveletek alapjául szolgálhat (pl. folytatható számítás).

### 2.4. Törlési funkciók
- **C:** Az aktuális művelet és az eddig bevitt adatok törlése.  
- **CE:** Az utolsó bevitt szám vagy műveleti elem törlése.

### 2.5. Hibakezelés
- A program felismeri és kezeli a **0-val való osztást**, és hibaüzenetet jelenít meg:  
  > “Syntax error!”  
- Hibás műveletsorozat esetén (pl. egymás utáni operátorok) a program figyelmen kívül hagyja az érvénytelen bevitelek hatását.  
- Hibás állapot után a program visszaáll **alaphelyzetbe**, hogy új művelet indítható legyen.

---

## 3. Felhasználói felület leírása

### 3.1. Megjelenés
- Letisztult, **iPhone-stílusú dizájn**.  
- Lekerekített gombok és szimmetrikus elrendezés.  
- A gombok elrendezése a klasszikus számológép formát követi.  
- A kijelző a gombok felett helyezkedik el, és folyamatosan mutatja a bevitt értékeket, műveleteket és az eredményt.

### 3.2. Felhasználói műveletek

| Művelet típusa | Leírás | Eredmény |
|-----------------|--------|----------|
| Számgomb megnyomása | Szám bevitele | Szám megjelenik a kijelzőn |
| Operátor gomb megnyomása | Művelet kiválasztása | Operátor tárolása |
| “=” gomb megnyomása | Művelet végrehajtása | Eredmény megjelenítése |
| “C” gomb megnyomása | Teljes törlés | Kijelző ürül |
| “CE” gomb megnyomása | Utolsó bevitel törlése | Kijelző frissül |
| 0-val osztás | Érvénytelen művelet | Hibaüzenet megjelenítése |

---

## 4. Rendszerkövetelmények
- **Fejlesztési környezet:** Visual Studio 2022 (vagy újabb)  
- **Programozási nyelv:** C#  
- **Futtatási környezet:** Windows operációs rendszer (.NET támogatással)  
- **Felhasználói interfész:** Windows Forms alkalmazás

---

## 5. Nem funkcionális követelmények
- **Használhatóság:** Egyszerű, áttekinthető kezelőfelület, kezdő felhasználók számára is.  
- **Megbízhatóság:** Hibakezelés beépítve a tipikus matematikai kivételekre.  
- **Teljesítmény:** Az eredmények valós időben jelenjenek meg.  
- **Karbantarthatóság:** A kód jól tagolt, kommentált, könnyen továbbfejleszthető.  
- **Esztétika:** Modern, lekerekített grafikai elemek; az iPhone számológép dizájnjához hasonló vizuális megjelenés.

---

## 6. Használati forgatókönyv
1. A felhasználó elindítja a programot.  
2. A felhasználó beviszi az első számot (pl. **8**).  
3. A felhasználó kiválasztja a műveletet (pl. **÷**).  
4. A felhasználó beviszi a második számot (pl. **2**).  
5. A felhasználó megnyomja az **“=”** gombot.  
6. A program kiszámítja az eredményt (**4**) és megjeleníti a kijelzőn.  
7. A felhasználó új műveletet indíthat, vagy törölheti az aktuális értéket.

---

## 7. Fejlesztési korlátok
- A program csak alapműveleteket támogat.  
- Tudományos és memóriaműveletek nem részei az első verziónak.  
- Kizárólag Windows rendszeren működik.

---
