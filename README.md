# Ipo2 - PokeGo

🔹 Link repositorio -> https://github.com/molinem/ipo2-pokeGo

Aplicación desarrollada utilizando C# y WPF. En ella, podemos encontrar 3 "Pages" independientes:

## Inicio
Encontramos un `<b>mediaElement</b>` que actua de fondo reproduciendo un vídeo de la intro de pokemon, además hay un cuadro de texto mostrando los integrantes del proyecto.
<br>

![image](https://github.com/molinem/ipo2-pokeGo/assets/47080025/f68b3a05-9eb3-49a8-a753-2f91752b9ea5)

***

## Pokedex
Contiene algunos pokemons extraidos de forma directa de la base de datos permitiendo con ello que podamos añadir pokemons de una forma rápida y sencilla sin necesidad de modificar el código. </br>
Los pokemons son cargados en un lista dinámica permitiendo mostrar la información del mismo en la parte derecha de la pantalla.
* Hay dos botones en la interfaz:
  - La lupa para hacer búsquedas por el nombre del pokemon introduciéndolo en la caja de texto -> filtrando en la list-view
  - Recargar: para mostrar todos los pokemons.

![image](https://github.com/molinem/ipo2-pokeGo/assets/47080025/dd40a2e3-2cf6-497b-9ef9-6032cf739a13)

***

## Batalla Pokemon
Hay dos formas de realizar la batalla:
 - El jugador contra la IA
 - El jugador contra otro jugador
A continuación, se muestran algunas capturas de la selección de pokemon y batalla del mismo

![image](https://github.com/molinem/ipo2-pokeGo/assets/47080025/3c04c672-3bc8-48bc-975e-28588cc49b6a)

![image](https://github.com/molinem/ipo2-pokeGo/assets/47080025/9ff08a76-6cf4-407b-ae5b-e4f40d323652)

![image](https://github.com/molinem/ipo2-pokeGo/assets/47080025/84440d7e-5d29-42d9-8b7a-8c1fa76421cd)

***

## Accesibilidad
Para mejorar la accesibilidad de la aplicación todos los botones/imágenes tienen tooltips, además se lanzan notificaciones cuando ganas/pierdes una batalla.

