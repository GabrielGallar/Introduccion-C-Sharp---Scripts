# Introduccion-C-Sharp---Scripts
Primera práctica de la asignatura "Interfaces Inteligentes"
# Hitos Generales
- Creación y asociación de un script a un GameObject:
Se crea un script que hereda de MonoBehaviour y se asocia a un objeto de la escena para controlar su comportamiento.
- Parametrización mediante el Inspector: 
Se declara una variable de clase como pública para poder ser modificada desde el Inspector.
- Visualización de los resultados en la consola: 
Se utiliza Debug.Log() para visualzar mensajes o resultados en la consola de Unity.
- Comprobación de cambios  mediante Update(): 
Se utiliza Update() para aplicar o no cambios constantemente.
- Uso de estructuras condicionales:
Se utiliza una estructura if / else if / else para distinguir entre los posibles resultados.
## Hitos Ejercicio 1 (Cambiar color)
- Inicialización de un color mediante valores aleatorios: Se utiliza Random.value para generar tres valores aleatorios entre 0.0 y 1.0
- Uso de la clase Color: Se utiliza un objeto Color para representar el color del GameObject mediante sus componentes r, g y b.
- Obtención del componente Renderer: Se utiliza GetComponent<Renderer>() para obtener una referencia al componente Renderer del objeto y poder modificar su material.
- Modificación del color del objeto: Se utiliza renderizado.material.color para asignar al objeto el color generado.
- Ejecución periódica mediante frames: Se utiliza Update() junto con Time.frameCount y el operador módulo (%) para ejecutar el cambio de color cada cierto número de frames.
- Selección aleatoria de una componente del color: Se utiliza Random.Range(0, 3) para seleccionar aleatoriamente una de las tres componentes del color.
  <img width="1920" height="1080" alt="Cambiar_Color_N-Trim" src="https://github.com/user-attachments/assets/4db1fd9c-e395-43a3-a6db-4eb255b99294" />

## Hitos Ejercicio 2 (Vectores)
- Declaración de variables de tipo Vector3:
Se declaran dos variables públicas de tipo Vector3 para representar dos vectores tridimensionales, permitiendo modificar sus componentes desde el Inspector de Unity.
- Cálculo de la magnitud de los vectores:
Se utiliza la propiedad magnitude para obtener la longitud de cada vector, calculada a partir de sus tres componentes.
- Cálculo del ángulo entre dos vectores:
Se emplea el método Vector3.Angle() para calcular el ángulo, expresado en grados, que forman los dos vectores.
- Cálculo de la distancia entre dos vectores:
Se utiliza Vector3.Distance() para obtener la distancia euclídea entre los puntos representados por ambos vectores.
- Validación de los valores desde el Inspector:
Se utiliza el método OnValidate() para ejecutar los cálculos y actualizar los mensajes de la consola cuando se modifican los valores de los vectores desde el Inspector.
<img width="1920" height="1080" alt="Vectores_ins-Trim" src="https://github.com/user-attachments/assets/a3f944e9-e0a9-4db7-b712-ff1f00560898" />

## Hitos Ejercicio 3 (Referenciar Posición)
- Acceso al componente Transform del GameObject:
Se utiliza transform para acceder al componente Transform de la esfera, que contiene información sobre su posición, rotación y escala.
- Obtención de la posición mediante transform.position:
Se utiliza transform.position para obtener la posición de la esfera, representada mediante un Vector3 con sus componentes X, Y y Z.
- Detección del movimiento del objeto: Se compara la posición anterior con la posición actual y si después de detectar un cambio, se actualiza posicion_inical con la nueva posición.
<img width="1920" height="1080" alt="Referencia_pos-Trim" src="https://github.com/user-attachments/assets/1f7db710-2e67-42bf-8e27-2166be0ae6dc" />

## Hitos Ejercicio 4 (Medir Distancias)
- Búsqueda de GameObjects mediante Tags: Se utiliza GameObject.FindWithTag() para localizar el cubo y el cilindro
- Obtención de la posición de los GameObjects:
A partir de cada GameObject se accede a su componente Transform y posteriormente a su posición.
- Almacenamiento de posiciones mediante Vector3:
Se guardan las posiciones del cilindro, cubo y esfera para luego si es necesario actualizarlas.
- Cálculo de distancias entre posiciones
- Uso de métodos propios para organizar el código (MedimosDistancias)
- Actualización dinámica de las distancias
<img width="1920" height="1080" alt="Medir_Distancias_N-Trim" src="https://github.com/user-attachments/assets/574da02e-455c-4734-948e-826c71590f1c" />
