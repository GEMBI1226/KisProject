# Követelményspecifikáció – Számológép Projekt

## 1. A rendszer célja
A projekt célja egy modern, esztétikus és felhasználóbarát számológép alkalmazás fejlesztése számítógépes környezetre.  
A program célja az alapvető matematikai műveletek (összeadás, kivonás, szorzás, osztás) elvégzésének biztosítása egy letisztult, az iPhone kalkulátor dizájnját idéző grafikus felületen.

---

## 2. A rendszer indoklása
A jelenleg elérhető számológép-alkalmazások vizuális megjelenése elavult, nem illeszkedik a modern számítógépes rendszerek grafikai trendjeihez.  
A fejlesztés célja, hogy egy korszerű, lekerekített gombokkal, letisztult felülettel és intuitív működéssel rendelkező alternatívát nyújtson, amely a mai felhasználói elvárásoknak megfelel.

---

## 3. Rendszerkörnyezet
- **Fejlesztői környezet:** Microsoft Visual Studio 2022 (vagy újabb)  
- **Fejlesztési nyelv:** C#  
- **Futtatási környezet:** Windows operációs rendszer (.NET kompatibilis)  
- **Felhasználói interfész:** Windows Forms alapú grafikus felület

---

## 4. Funkcionális követelmények
A programnak az alábbi funkciókat kell biztosítania:

### Számbevitel
- 0–9 gombok segítségével történő számbevitel.

### Alapműveletek
- Összeadás (+)  
- Kivonás (–)  
- Szorzás (×)  
- Osztás (÷)

### Eredmény megjelenítése
- Az elvégzett művelet eredményének kijelzése a kijelző mezőben az **=** gomb megnyomásakor.

### Törlési funkciók
- **C:** Teljes törlés (minden adat törlése).  
- **CE:** Utolsó bevitel törlése.

### Hibakezelés
- 0-val való osztás esetén hibaüzenet megjelenítése.  
- Érvénytelen műveletsorozat (pl. dupla operátor) kezelése.

---

## 5. Nem funkcionális követelmények
- **Felhasználóbarát felület:** Egyszerű, letisztult dizájn, lekerekített gombokkal.  
- **Megbízhatóság:** A program hibamentesen kezelje a matematikai és logikai kivételeket.  
- **Teljesítmény:** A számítások azonnal, késlekedés nélkül jelenjenek meg.  
- **Karbantarthatóság:** A kód jól strukturált, kommentelt és bővíthető legyen.

---

## 6. Használati leírás
1. A projekt megnyitása **Visual Studio**-ban.  
2. A program futtatása a **Build** és **Run (F5)** parancsokkal.  
3. A felhasználó a megjelenő grafikus felületen keresztül használhatja a számológépet.

---

## 7. Célcsoport
A programot olyan felhasználók számára terveztük, akik számítógépen szeretnének egyszerű, megbízható és esztétikus számológépet használni, akár alapszintű informatikai ismeretekkel is.

---

## 8. Fejlesztési korlátok
- Csak alapműveletek támogatottak.  
- Tudományos funkciók (sin, cos, sqrt stb.) nem kerülnek implementálásra.  
- Kizárólag Windows rendszeren futtatható.

---
