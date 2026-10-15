# 🧩 Adoki

## 📖 Descripción

Adoki es una solución desarrollada en .NET 10, compuesta por dos proyectos principales:
* Adoki.app → Aplicación .NET MAUI, interfaz multiplataforma (Windows, Android, iOS).
* Adoki.logic → Biblioteca de clases que contiene la lógica de negocio y las entidades del dominio.
Esta estructura separa la capa de presentación (UI) de la lógica interna, permitiendo mantener
un diseño limpio, modular y escalable.

---

## ⚙️ Tecnologías utilizadas

* .NET 10 SDK
* .NET MAUI (para la app multiplataforma) 
* C# 14
* Visual Studio Code o Visual Studio 2025
* NuGet (para gestión de dependencias)

---

## 📦 Dependencias principales

| Tipo | Dependencia | Comando / Método de instalación | Alternativas |
| --- | --- | --- | --- |
| SDK | .NET 10 | ``winget ``install ``Microsoft.DotNet.SDK.10`` | Instalar manualmente desde [dotnet.microsoft.com](https://dotnet.microsoft.com) |
| Workload | MAUI | ``dotnet ``workload ``install ``maui`` | — |
| Herramientas Android | Android SDK Platform Tools | ``winget ``install ``Google.AndroidSDK.PlatformTools`` | Descargar desde developer.android.com o usar ``sdkmanager`` sin Android Studio |
| CLI | Herramientas MAUI | ``dotnet ``workload ``list`` (para verificar) | — |
| JDK | **Java 17 o 21** (requerido por MAUI Android) | ``winget ``install ``EclipseAdoptium.Temurin.21.JDK`` | **Microsoft Build of OpenJDK 21** → ``winget ``install ``Microsoft.OpenJDK.21`` |

---
