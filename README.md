# MyFirstARProject! - Lab 1 Mixed Reality

Aplicație Augmented Reality realizată în Unity cu Vuforia Engine, care plasează două personaje 3D pe trackere de imagine și le modifică animația pe baza distanței dintre ele.

## Cerințe & Funcționalități

* **Trackere Vuforia:** Aplicația recunoaște simultan două `Image Targets` distincte.
* **Personaje & Animații:** 
  * Două personaje preluate de pe Unity Asset Store (Knight și Skeleton).
  * Fiecare personaj conține un Animator Controller cu două stări: `Idle` (implicit) și `Attack`.
* **Detecție de proximitate:**
  * Scriptul C# `ProximityChecker` monitorizează distanța 3D dintre cele două personaje în `Update()`.
  * Când distanța scade sub pragul de **0.25m**, parametrul `isClose` devine `true`, iar ambele personaje trec automat din `Idle` în `Attack`.
  * Când sunt îndepărtate, revin în `Idle`.
* **Platforme:** Testat atât pe Android (build APK), cât și în Editor (webcam PC).

## Structura Proiectului

* `Assets/Scenes/` - Scena principală cu `ARCamera`, `ImageTargets` și scriptul de proximitate.
* `Assets/Scripts/` - `ProximityChecker.cs`.
* `Trackers/` *(opțional)* - Imaginile folosite ca target-uri pentru testare.

## Cum se rulează

1. Se deschide proiectul în Unity (recomandat 6000.x).
2. Se asigură prezența pachetului Vuforia Engine și a licenței de developer în `Vuforia Configuration`.
3. Se deschide scena din `Build Settings` (Index 0).
4. Se apasă **Play** (pentru testare cu webcam) sau se compilează APK-ul via **File > Build** pentru Android (API 29+).
5. Se îndreaptă camera către cele două imagini de tracking imprimate sau afișate pe ecran.
