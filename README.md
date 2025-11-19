# ZeroLauncher mod para MuKonoha (KonohaLauncher)

## Codigo:

El codigo fué descompilado manualmente, convertido a proyecto C# + Net Framework 3.5 para hacerlo compatible con Visual Studio y VSCode

## Cambios:
### Funciones:

* Habilitar/Deshabilitar los 60 FPS
* Activar/Desactivar el indicador de RTT, Ping, etc.
* Activar/Desactivar reloj del sistema y del server in-game
* Habiltiar/Deshabilitar Discord RPC

### Extras:

* Se cambió el icono del ejecutable por el de MuKonoha (sacado de "https://konohamu.com/templates/4/favicon.ico")
* Se vinculó el icono visible en la barra de tareas de los forms Main y Settings al icono del ejecutable para mantener la consistencia.
* Se actualizó la info del assembly del ejecutable
* Se ajustó el tamaño de "opcionbg.bmp" ("Data\Launcher\GRAFICOS\opcionbg.bmp") para que los nuevos checkboxes queden bien
* Se ajustaron los tamaños de los select y el textbox (default id, screen resolution y lenguaje) para que queden bien con el nuevo tamaño del form Settings
* Se refactorizó una parte muy chiquita de la comprobación de estado del servidor remoto (estaba hecho con los codos).

## Futuros cambios (To-Do) si se requieren:
* Cambiar index y parches a un CDN o similar. Si se cae la web se cae el launcher, eso no está nada bueno
* Agregar comprobacion de estado del servidor, eso incluye indicador Online/Offline
* Más opciones de configuración (AntiLag por ejemplo)
* Creación de perfiles default de configuracion para el AntiLag (ejemplo: "Modo rendimiento", "Modo balanceado", "Modo calidad"), una forma facil y rápida para los usuarios de cambiar "presets" graficos según la PC que tengan con 1 solo click.
* Crear/Diseñar un botón u opción para comprobar el estado del cliente y repararlo automáticamente si requiere, similar a lo que hacen launchers como Battle.Net, Steam, Epic, etc. (LÓGICA: se listan los archivos, se comparan los hashes md5 o sha256 con los del servidor, si alguno no coincide asumimos que está corrupto o no existe y se descarga de nuevo).
* Acomodar el checkbox de Winmode o incluirlo en Settings (sería lo mejor).
* Hardcodear datos del servidor (ip, puerto, url) en el codigo del launcher para dejar de usar el "Config.ini" encriptado, que no tiene sentido que esté encriptado porque el launcher es público y la clave de desencriptado también, es como si en un .RAR con contraseña y el nombre del archivo RAR fuese la contraseña, totalmente al pedo.
* Sacar el webbrowser pija que tiene el launcher y por lo tanto el boton "News" en la parte superior izquierda. (Los webbrowsers de Net Framework usan la API de Internet Explorer, que está descontinuada y no está disponible en W10 y W11, esto genera problemas como fallos por ssl/https y similares.)

## Imágenes

![Muestra de settings.](https://i.imgur.com/5l4Xrc5.png "Muestra de settings")
![Muestra de icons.](https://i.imgur.com/7yprT76.png "Muestra de icons")
