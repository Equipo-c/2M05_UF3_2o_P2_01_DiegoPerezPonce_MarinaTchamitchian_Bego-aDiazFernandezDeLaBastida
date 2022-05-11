

<h1 align="center"> M05_UF3_2o_P2_01_DiegoPerezPonce_MarinaTchamitchian_Bego-aDiazFernandezDeLaBastida </h1> <br>

<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DON'T EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->
## Tabla de Contenido

- [Introduccion](#introduccion)
- [Equipo](#equipo)
- [Programas](#programas)
- [Base de Datos](#base-de-datos)
- [Paginas](#paginas)
- [Problemas Incontrados](#problemas-incontrados)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

## Introduccion

La realización de una aplicación de servidor web en Razor. Diseñar una base de datos en sql, y un backend web en c# siguiendo el siguiente esquema UML:.

<p align="center">
  <img src = "https://cdn.discordapp.com/attachments/901878120800456754/973963827605569576/M05_UF3_P2_Diagram.jpg" width=350>
</p>

## Equipo

Nuestro equipo de GitHub es [Equipo-c](https://github.com/Equipo-c) :
- [Marina Tchamitchian](https://github.com/blueMuse51).
- [Begoña Diaz Fernandez de la Bastida](https://github.com/Araetz).
- [Diego Perez Ponce](https://github/Dissit20).

## Programas

**Una lista de los programas utilizados dentro del proyecto:**
- [Visual Studio 2019] (#vs19)
- [GitHub](#github)
- [Razor](#razor)

## Base de Datos 
Contiene cuatro tablas, las cuales estan relacionadas con las paginas y modelos del mismo nombre. Son:
- [Product](#product)
- [Company](#company)
- [Game](#game)
- [Video](#video)
<p align="center">
  <img src = "https://cdn.discordapp.com/attachments/901878120800456754/973966894346428556/bd.jpg" width=300>
</p>

## Paginas



## Problemas Incontrados

Conectar el boton de type (game, video) que esta en la pagina "SearcherProducts" con la pagina del type (Game, Video).
<p align="center">
  <img src = "https://cdn.discordapp.com/attachments/901878120800456754/973969264040087562/errorrr.jpg" width=700>
</p>

<p align="center">
  <img src = "https://cdn.discordapp.com/attachments/901878120800456754/973964498740326410/error1.jpg" width=700>
</p>
                                                                                                     
<p align="center">
  <img src = "https://cdn.discordapp.com/attachments/901878120800456754/973964400253874257/error1a.jpg" width=700>
</p>

Hemos intentado relacionar la tabla Product con la tabla Game, atravez de añadir una nueva fila en la tabla de Product, que representa el game ID (de la misma forma como hemos relacionado la tabla Company con la tabla Product). Pero, no hemos podido actualizar la base de datos, el error se muestra en la siguiente foto:

<p align="center">
  <img src = "https://cdn.discordapp.com/attachments/901878120800456754/973971908964020244/errrrorrr.jpg" width=700>
</p>
