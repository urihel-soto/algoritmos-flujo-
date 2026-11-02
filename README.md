# Algoritmos-flujo

## Proyecto: Prácticas de Consola en C# (Actividad 1 y Actividad 2)

## Integrantes del Equipo
- **Génesis Altagracia de la Cruz Perozo** | Matrícula: 25-SISN-2-051
- **Dalbert Yordani Hernández Alcántara** | Matrícula: 26-EISN-2-014
- **Emmanuel Javier Mercedes** | Matrícula: 26-EISN-2-023
- **Urihel Soto De Peña** | Matrícula: 26-EISN-2-032
- **Yokenddy Amparo Silvestre** | Matrícula: 26-EISN-2-002
- **Antoni Ramírez Mercedes** | Matrícula: 26-EISN-2-019

---

## Descripción del Proyecto
Este repositorio contiene el desarrollo de dos aplicaciones de consola orientadas a afianzar la lógica de programación mediante estructuras de control, manejo de cadenas y funciones.

---

## Actividad 1: Control de Acceso al Cine

### Descripción
Programa de consola diseñado para evaluar de manera interactiva si una persona califica para ingresar al cine y calcular la tarifa correspondiente según su edad y género.

### Temas que se practican
- Estructuras condicionales (`if`, `else if`).
- Estructura de selección múltiple (`switch`).
- Bucle repetitivo (`do-while`).
- Funciones y manipulación de cadenas (`string`, `ToUpper()`.

### Requisitos y Proceso
1. **Lectura de datos:** Se solicita al usuario ingresar su nombre, edad y género (`F` o `M`). Se utiliza el método `.ToUpper()` para estandarizar la comparación del género.
2. **Función Categoria(int edad):** Evalúa la edad ingresada y retorna una categoría mediante sentencias condicionales: *Niño*, *Adolescente*, *Adulto* o *Adulto mayor*.
3. **Reglas de negocio:**
   - Menores de 18 años no entran.
   - Mujeres entran gratis.
   - Hombres pagan una tarifa de RD$300.
4. **Menú interactivo:** Implementado con un `switch` anidado dentro de un `do-while` con tres opciones principales: 
   1. Registrar
   2. Tarifas
   3. Salir
5. **Reto extra:** Inclusión de una función lógica que recibe tres montos y muestra cuál es el mayor, el menor y el del centro.

### Entrada
- Nombre del usuario (Texto)
- Edad (Número entero)
- Género (`F` o `M`)

### Salida
- Muestra en consola el nombre formateado, la categoría calculada y el estado de la entrada (Ej. *Entrada GRATIS* o monto a pagar).
  
---

## Actividad 2: Adivina el Número

### Descripción
Juego interactivo de consola donde el usuario debe adivinar un número secreto generado de manera aleatoria entre el 1 y el 50, recibiendo pistas direccionales en cada intento.

### Temas que se practican
- Bucles y ciclos (`do-while`, `for`, `while`).
- Estructuras de control (`if / else`).
- Funciones y manipulación de cadenas (`string`, `Substring`, `ToLower`).

### Requisitos y Proceso
1. **Captura de nombre:** Se pide el nombre del usuario, se muestra en mayúsculas (`ToUpper()`) y se extrae su inicial utilizando `Substring(0, 1)`.
2. **Generación aleatoria:** El sistema genera un número secreto utilizando `new Random().Next(1, 51)`.
3. **Validación y pistas (`do-while`):** Se solicitan números continuamente hasta que el usuario acierte, proporcionando pistas textuales como *"Más alto"* o *"Más bajo"* según corresponda.
4. **Validación de rango:** Función `PedirNumero()` encargada de validar estrictamente que la entrada se mantenga en el rango de 1 a 50.
5. **Conteo de intentos:** Al ganar, se imprime un asterisco (`*`) por cada intento realizado utilizando un bucle `for`, y se consulta si desea jugar otra vez utilizando un ciclo `while` y `.ToLower()`.

### Entrada
- Nombre del jugador (Texto)
- Selección de números sucesivos (Enteros del 1 al 50)
- Opción de continuidad (`s`/`n`).

### Salida
- Mensajes de guía (*"Más alto"* / *"Más bajo"*), conteo total de intentos con formato gráfico de asteriscos y confirmación de acierto.

---

## Cómo Ejecutar
1. Clona este repositorio o descarga los archivos fuente del proyecto.
2. Abre tu entorno de desarrollo o terminal compatible con C# (como Visual Studio o Visual Studio Code).
3. Compila y ejecuta el archivo principal (`Program.cs`) utilizando el comando de compilación de tu preferencia o ejecutando directamente desde el IDE.

---
*(Nota: Las capturas de pantalla de la ejecución de ambos programas en sus distintos escenarios se encuentran detalladas en el apartado correspondiente del informe).*
