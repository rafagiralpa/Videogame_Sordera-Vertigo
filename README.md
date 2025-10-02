Este repositorio contiene un proyecto de Unity para el desarrollo de un videojuego enfocado en unos ejercicios de la rehabilitacion vestibular.
Incluye todos los recursos necesarios (scripts, escenas, assets y configuraciones) para abrir, ejecutar y continuar el desarrollo en Unity.



Videogame_Sordera_Vertigo/
│
├── Assets/                     # Recursos principales del juego
│   ├── Challenges/             # Carpetas de retos o minijuegos
│   ├── Low-Poly Medieval Market/ # Modelos y entornos descargados
│   ├── Oculus/                 # Integración con Oculus/VR
│   ├── Plugins/                # Plugins externos de Unity
│   ├── Resources/              # Recursos cargables en runtime
│   ├── Samples/                # Ejemplos y recursos de prueba
│   ├── Scenes/                 # Escenas del proyecto (.unity)
│   ├── Scripts/                # Código en C# (mecánicas de juego)
│   ├── Settings/               # Ajustes adicionales
│   ├── SkySeries Freebie/      # Recursos de cielo/entorno
│   ├── SyntyStudios/           # Assets de Synty (estilo low poly)
│   ├── TextMesh Pro/           # Fuente y UI de texto avanzado
│   ├── Tree_Textures/          # Texturas de árboles
│   ├── XR/                     # Extensiones para realidad virtual
│   └── Audio/                  # Música y efectos de sonido
│
├── Packages/                   # Configuración de paquetes de Unity
│   ├── manifest.json           # Paquetes activos del proyecto
│   └── packages-lock.json      # Bloqueo de versiones
│
├── ProjectSettings/             # Configuración global del proyecto
│   ├── InputManager.asset      # Configuración de entradas (teclado, gamepad, VR)
│   ├── GraphicsSettings.asset  # Configuración de gráficos
│   ├── QualitySettings.asset   # Calidad de renderizado
│   ├── ProjectVersion.txt      # Versión de Unity usada en el proyecto
│   └── ...                     # Otros ajustes (física, tiempo, etiquetas, etc.)
│
├── .gitignore                  # Archivos/carpetas ignorados en Git
└── README.md                   # Documentación del proyecto




## Archivos y carpetas principales del proyecto 

### Carpeta `Assets/`

Es la parte más importante: aquí están todos los recursos y el código del juego.

* **Challenges/** → Carpeta donde probablemente estén minijuegos o escenas relacionadas con los retos que planteas en el videojuego.
* **Low-Poly Medieval Market/** → Assets de mercado medieval (modelos 3D, texturas, materiales).
* **Oculus/** → Librerías y scripts para integrar el juego con Oculus VR.
* **Plugins/** → Plugins externos (código o librerías nativas añadidas al proyecto).
* **Resources/** → Carpeta especial de Unity: todo lo que esté aquí puede cargarse dinámicamente en tiempo de ejecución con `Resources.Load()`.
* **Samples/** → Ejemplos de paquetes que has importado (generalmente vienen con Unity o la Asset Store).
* **Scenes/** → Escenas del juego en formato `.unity`. Cada escena es un "nivel" o pantalla.
* **Scripts/** → Código en C# con la lógica del juego (mecánicas, controladores, etc.).
* **Settings/** → Configuraciones específicas de algunos paquetes.
* **SkySeries Freebie/** → Cielos y entornos para el escenario (skyboxes).
* **SyntyStudios/** → Assets de Synty Studios (modelos low-poly, props, personajes).
* **TextMesh Pro/** → Sistema de texto avanzado para UI y HUD.
* **Tree_Textures/** → Texturas de árboles.
* **XR/** → Recursos relacionados con XR (realidad extendida: VR y AR).
* **Audio/** → Carpeta donde deberías tener música, sonidos de ambiente y efectos.



### Carpeta `Packages/`

Aquí Unity guarda la gestión de dependencias.

* **manifest.json** → Lista de todos los paquetes que el proyecto necesita (Input System, XR, TextMeshPro, etc.).
* **packages-lock.json** → Bloquea las versiones exactas de los paquetes instalados para que todo funcione igual en cualquier PC.



### Carpeta `ProjectSettings/`

Son configuraciones globales del proyecto, no de un asset en concreto.
**InputManager.asset** → Configuración de teclas, mandos o dispositivos de entrada (en caso de usar el sistema clásico de inputs).
**GraphicsSettings.asset** → Ajustes de renderizado (shaders, calidad, pipeline).
**QualitySettings.asset** → Ajustes de calidad (baja, media, alta, ultra).
**ProjectVersion.txt** → Indica la versión exacta de Unity con la que se creó el proyecto. Muy útil para abrirlo sin errores.
**Otros .asset** → Configuración de etiquetas, capas, tiempo, física, etc.



### Archivos sueltos

**.gitignore** → Lista de carpetas y archivos que Git no debe subir al repositorio (por ejemplo `Library/`, `Temp/`, `Builds/`).
**README.md** → Documento de introducción al proyecto (puedes poner descripción, instalación y estructura, como el que estamos escribiendo).

En pocas palabras:
**Assets/** → Lo que tú desarrollas (código, escenas, assets).
**Packages/** → Dependencias externas.
**ProjectSettings/** → Configuración del proyecto.
**.gitignore** → Para evitar subir basura a GitHub.
**README.md** → Documentación para otros desarrolladores.




COMO ABRIR EL PORYECTO EN UNITY:
Clonar el repositorio: git clone https://github.com/tuusuario/Videogame_Sordera_Vertigo.git

1.Abrir con Unity Hub:
-Abrir Unity Hub.
-Seleccionar "Add project from disk".
-Escoger la carpeta raíz Videogame_Sordera_Vertigo/

2.Seleccionar la versión correcta de Unity:
-El archivo ProjectSettings/ProjectVersion.txt indica la versión exacta usada para crear el proyecto.
-Si no está instalada, Unity Hub sugerirá instalarla o abrir el proyecto con otra compatible.

3.Ejecutar el juego:
-Acceder a la carpeta Assets/Scenes/.
-Abrir la escena principal (por ejemplo MainScene.unity).
-Presionar "Play" en el editor para ejecutar el juego.


TECNOLOGIAS USADAS
-Unity Engine
-C# para la lógica del juego
-ShaderLab / HLSL para efectos visuales
-TextMesh Pro para el renderizado de texto en UI
-Integración con XR/Oculus para realidad virtual
