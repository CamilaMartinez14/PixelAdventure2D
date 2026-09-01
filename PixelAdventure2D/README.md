# Pixel Adventure 2D - Escapar de la Selva

## Descripción

Pixel Adventure 2D es un juego de aventura que realicé en Unity. La idea principal es ayudar a Cami a recorrer una selva y superar diferentes obstáculos hasta encontrar el tesoro que está escondido al final.

Durante el recorrido Cami puede caminar, correr, saltar y agacharse. También debe evitar diferentes peligros e interactuar con algunos objetos que son necesarios para poder seguir avanzando.

Quise que el juego tuviera diferentes partes y que no fuera solamente llegar de un punto a otro. Por eso fui agregando obstáculos, objetos interactivos y una parte de la selva que cambia a un ambiente más oscuro durante el recorrido.

## Historia del juego

Cami comienza su aventura recorriendo la selva y durante el camino encuentra un cofre que puede abrir. Dentro del cofre encuentra una planta especial que le entrega más fuerza.

Después debe seguir avanzando y evitar diferentes peligros como las trampas. También llega a un río que tiene que cruzar saltando por las partes de un puente roto. Si cae al agua vuelve al inicio de esa zona y tiene que intentarlo nuevamente.

Más adelante Cami llega a una parte más oscura de la selva donde encuentra antorchas que puede prender. En esta zona también agregué diferentes elementos como piedras, troncos, señales y ruinas para acompañar el recorrido.

Casi al final Cami encuentra una piedra grande que está bloqueando el camino hacia el tesoro. Para poder moverla necesita haber conseguido anteriormente la fuerza de la planta. Si tiene la fuerza puede mover la piedra utilizando la tecla E y así liberar el camino.

Finalmente Cami puede llegar al último cofre. Al interactuar con él el cofre se abre y aparece el mensaje "¡Encontraste el tesoro de la selva!" indicando que terminó el recorrido.

## Controles

- A o flecha izquierda: mover a Cami hacia la izquierda
- D o flecha derecha: mover a Cami hacia la derecha
- Shift: correr más rápido
- Espacio: saltar
- S o flecha hacia abajo: agacharse
- E: interactuar con los objetos

## Mecánicas que realicé

- Movimiento de Cami hacia la izquierda y derecha
- Opción de correr más rápido
- Salto del personaje
- Opción de agacharse
- Detección del suelo para controlar el salto
- Animación de Cami cuando está quieta
- Animación al caminar
- Animación al correr
- Animación al saltar
- Animación al agacharse
- Cámara que sigue a Cami durante el recorrido
- Cofre interactivo que se puede abrir con la tecla E
- Planta especial que Cami puede recoger
- Sistema de fuerza después de obtener la planta
- Trampas que hacen volver a Cami al inicio
- Río que funciona como zona de peligro
- Punto de reinicio cuando Cami cae al agua
- Puente roto formado por diferentes partes que Cami debe cruzar
- Cambio del ambiente a una zona más oscura de la selva
- Antorchas que Cami puede prender utilizando la tecla E
- Piedras, troncos, señales y ruinas como parte del escenario
- Piedra grande que bloquea el camino hacia el tesoro
- Interacción para mover la piedra solamente si Cami consiguió la fuerza
- Cofre final interactivo
- Cambio del sprite del cofre cuando se abre
- Mensaje final cuando Cami encuentra el tesoro
- Uso de Collider 2D para el suelo, obstáculos e interacciones
- Uso de Is Trigger para detectar algunas interacciones y peligros

## Proceso de desarrollo

Para realizar este proyecto fui trabajando de a poco porque varias cosas me costaron más de lo que pensaba. Primero comencé preparando el escenario y el personaje. Después fui trabajando el movimiento de Cami para que pudiera caminar hacia ambos lados y saltar.

Cuando el movimiento comenzó a funcionar fui agregando las animaciones. Cami puede estar quieta, caminar, correr, saltar y también agacharse. Agregué la opción de correr más rápido porque al hacer el escenario más largo sentí que solamente caminar hacía que el recorrido fuera un poco lento.

Una de las cosas que más me costó fue trabajar con los Collider 2D. Al principio me costaba entender cuándo tenía que utilizar un collider normal y cuándo debía marcar Is Trigger. También tuve problemas con algunos terrenos porque Cami quedaba flotando o no detectaba correctamente el suelo. Tuve que cambiar algunos valores y probar varias veces hasta conseguir que funcionara bien.

Otra parte que me costó fue lograr que las diferentes interacciones se relacionaran entre ellas. Por ejemplo el primer cofre tenía que abrirse y mostrar la planta. Después Cami tenía que recoger esa planta para obtener fuerza y esa fuerza debía servir más adelante para mover la piedra que bloqueaba el camino hacia el tesoro.

El río y el puente también necesitaron varias pruebas. Cami debía poder saltar sobre las partes del puente pero si caía al agua tenía que volver al inicio de esa zona. Fui probando las posiciones y las colisiones hasta lograr que funcionara como quería.

Después fui agregando la parte nocturna de la selva. En esta zona agregué las antorchas y diferentes objetos para que el escenario no quedara tan vacío y también para que se notara un cambio mientras Cami avanzaba.

Para poder entender mejor varias de estas cosas tuve que buscar videos en YouTube sobre Unity y C#. Principalmente revisé videos y ejemplos relacionados con movimiento 2D, animaciones, Collider 2D e interacción con objetos. Esto me ayudó a entender mejor para qué servían algunos componentes y después fui probando lo aprendido directamente en mi proyecto.

Algo que me ayudó bastante fue probar cada cosa antes de continuar con la siguiente. Cuando algo no funcionaba intentaba encontrar primero el problema antes de seguir agregando más cosas. Algunas partes tuve que cambiarlas varias veces pero eso también me ayudó a entender mejor cómo funciona Unity.

Finalmente agregué la piedra que bloquea el último camino. Para moverla Cami necesita la fuerza que obtuvo anteriormente con la planta. Después de moverla puede llegar al cofre final y al abrirlo aparece el mensaje indicando que encontró el tesoro de la selva.

Este proyecto me costó en varias partes y tuve que hacer muchas pruebas pero siento que eso también fue parte del aprendizaje. Al terminarlo pude entender mucho mejor cómo funcionan los scripts, las animaciones, las colisiones y las interacciones entre diferentes objetos dentro de Unity.

## Herramientas utilizadas

- Unity 6000.0.77f1
- C#
- Visual Studio Code 1.134.0
- Git 2.55.0
- GitHub para guardar el proyecto y llevar el control de versiones
- YouTube como apoyo para revisar videos y ejemplos durante el desarrollo

## Autor

Camila Martinez Toro  
Estudiante de Ingeniería en Informática