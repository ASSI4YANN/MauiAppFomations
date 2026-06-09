# 📱 TutoAppFormations - Application Mobile MAUI

## 📌 Description

TutoAppFormations est une application mobile développée avec **.NET MAUI** permettant d’afficher et de consulter une liste de formations.

L’application consomme une **API REST développée en ASP.NET Core** pour récupérer les données des formations.

---

## 🚀 Prérequis

Avant de lancer l’application, assure-toi d’avoir :

* .NET 8 SDK ou supérieur
* Visual Studio 2022/2026 avec workload MAUI installé
* Un émulateur Android ou un appareil physique
* L’API backend ASP.NET Core fonctionnelle

---

## ⚙️ Lancement de l’API (OBLIGATOIRE)

L’application ne fonctionne pas sans le backend.

### 1. Ouvrir le projet API

Ouvre le projet **ASP.NET Core API** dans Visual Studio ou via terminal.

### 2. Lancer l’API

Exécute la commande :

```bash
dotnet run
```

ou lance via Visual Studio avec le bouton **Run / IIS Express**.

### 3. Vérifier l’URL de l’API

Par défaut, l’API tourne généralement sur :

```
https://localhost:xxxx
ou
http://localhost:xxxx
```

Note bien cette URL, elle est utilisée par l’application mobile.

---

## 📱 Lancement de l’application MAUI

### 1. Ouvrir le projet MAUI

Ouvre la solution `TutoAppFormations.sln`.

### 2. Vérifier la configuration API

Dans le code de l’application, vérifie que l’URL de l’API correspond à celle lancée.

Exemple :

```csharp
BaseUrl = "https://localhost:xxxx/api/formations";
```

---

### 3. Lancer l’application

Sélectionne un appareil Android ou un émulateur puis clique sur **Run**.

---

## 🔗 Fonctionnement

1. L’API ASP.NET Core fournit les données des formations
2. L’application MAUI consomme ces données via HTTP
3. Les formations sont affichées dans une interface mobile

---

## ⚠️ Important

* L’API doit être lancée **avant** l’application mobile
* Sans API, la liste des formations sera vide ou provoquera une erreur
* Vérifie que l’URL API est correcte et accessible depuis l’émulateur

---

## 🛠️ Technologies utilisées

* .NET MAUI
* ASP.NET Core Web API
* C#
* REST API
* HttpClient

---

## 👨‍💻 Auteur

Projet réalisé dans le cadre d’une formation .NET / DevOps
