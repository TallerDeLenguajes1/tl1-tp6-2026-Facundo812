# Ejercicio 4
## ¿String es una tipo por valor o un tipo por referencia?
String es un tipo por referencia
## ¿Qué secuencias de escape tiene el tipo string?
```
\'	Comilla simple
\"	Comilla doble	
\\	Barra invertida
\0	Nulo	
\a	Alerta
\b	Retroceso
\e	Escapar
\f	Avance de página
\n	Nueva línea
\r	Retorno de carro
\t	Tabulación horizontal
\v	Tabulación vertical
\u	Secuencia de escape Unicode (UTF-16)	
\U	Secuencia de escape Unicode (UTF-32)
\x	Secuencia de escape Unicode similar a "\u" excepto con longitud variable
```
## ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
cuando se utiliza "$" antes de una cadena de texto se declara una cadena interpolada, esta permite incluir variables dentro de llaves "{ }", por otro lado cuando se utiliza el caracter "@" se declara una cadena literal, este tipo de cadena se puede escribir en multiples lineas y las barras "\" no se interpretan como secuencia de escape