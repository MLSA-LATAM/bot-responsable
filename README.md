# bot-responsable
## Descripción 
Aprenderás cómo crear un bot sencillo para ayudar a memorizar los animales en inglés, aplicando las directivas para hacerlo responsable, utilizando plantillas de Visual Studio.

## Requisitos
Para la creación de este programa, se necesitan los siguientes programas instalados:

| Software | Instalación |
|----------|-------------|
| [Visual Studio](https://visualstudio.microsoft.com/?msclkid=9889c110c0e311ecb9230ebff5fdf967) | [Guía oficial](https://docs.microsoft.com/es-ES/visualstudio/install/install-visual-studio?view=vs-2022&preserve-view=true&viewFallbackFrom=vs-2019%3Fazure-portal%3Dtrue) |
| [Extensión Bot Framework v4 SDK para Visual Studio](https://github.com/microsoft/botbuilder-samples) | [Descarga](https://marketplace.visualstudio.com/items?itemName=BotBuilder.botbuilderv4&msclkid=e666a6cdc0e011ec8926f378a30d3470) |
| [Bot Framework Emulator](https://github.com/Microsoft/BotFramework-Emulator?msclkid=4afe4ff3c0e311ec8e8097bc4cd88e59) | [Descarga](https://aka.ms/abs/build/emulatordownload) |

## Instrucciones
### Creación del bot a partir de plantilla
Sigue estos pasos para crear el bot:

1. Desde la ventana de inicio de Visual Studio, selecciona Crear un proyecto nuevo.
2. En la página Crear un proyecto nuevo, en la lista de proyectos, selecciona AI Bots (Bots de IA) para mostrar solo las plantillas de bot.
3. Selecciona la plantilla Echo Bot (Bot Framework v4 - .NET Core 3.1) y después Siguiente.
4. Asigne al proyecto un nombre como AnimalHelp, seleccione una ubicación para el código y, después, seleccione Crear.

### Obtención de información
Para obtener la información que le servirá al bot para realizar las traducciones de los animales, se debe descargar el archivo 'animals.csv' [aquí](https://github.com/MLSA-LATAM/bot-responsable/blob/main/data/animals.csv) y se debe pegar en el directorio raíz donde se encuentra la plantilla.

### Codificación del bot
Crea un archivo nuevo dentro de la solución de 'AnimalHelp' de tipo 'Clase' y llámalo 'AnimalData.cs'. Dentro de este archivo copia el código del archivo 'AnimalData.cs' al que puedes acceder desde [aquí](https://github.com/MLSA-LATAM/bot-responsable/blob/main/src/AnimalData.cs)

### Agregar mensaje de bienvenida
Para el mensaje de bienvenida, se debe modificar el archivo 'EchoBot.cs'. Dichas modificaciones se encuentran [aquí](https://github.com/MLSA-LATAM/bot-responsable/blob/main/src/EchoBot.cs)

### Prueba del bot
Ejecuta el programa sin depurar en Visual Studio. Si todo sale bien, se desplegará una página web que contendrá la dirección en nuestro localhost en la cual se está ejecutando nuestro bot. Abre Bot Framework Emulator y pega dicha dirección el menú de abrir bot. 

De esta manera, ¡ya tenemos creado nuestro bot responsable!

Estos pasos se pueden extender para otro tipo de aplicaciones, pues podríamos tener diferentes bases de datos de las cuales nuestro bot obtendrá la informaión. En un ámbito empresarial sería útil para un servicio de respuestas automáticas a las preguntas más comunes. Si se tienen conocimientos más avanzados, se pueden integrar otros servicios de Azure Cognitive Services para cumplir con todos los requerimientos de un bot responsable.

## Recursos
Este tutorial está basado en módulo de Microsoft Learn [Creación de un bot de chat para ayudar a los alumnos a aprender geografía](https://docs.microsoft.com/es-mx/learn/modules/responsible-bots/). También puedes revisar el módulo [Introducción a los bots responsables](https://docs.microsoft.com/es-mx/learn/modules/responsible-bots-introduction/) para profundizar en los principios de bots responsables, así como el módulo [Implementación de un bot de servicio al cliente](https://docs.microsoft.com/es-mx/learn/modules/deploy-responsible-bot/) para aplicaciones empresariales de los bots responsables.

### Contribuidores
- [@FelFT](https://github.com/FelFT)
