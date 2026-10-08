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
- Configuración del proyecto para utilizar el sistema de entrada antiguo de Unity.
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

## Hitos Ejercicio 5 (Detectar Desplazamiento)
- Detección de la pulsación de la barra espaciadora mediante Input.GetAxis("Jump").
- Actualización de la posición de los objetos sumando el desplazamiento configurado a su posición inicial.
<img width="1920" height="1080" alt="Ej5" src="https://github.com/user-attachments/assets/8920670d-36c3-414d-8a8f-2349ab8d2058" />

## Hitos Ejercicio 6 (Calcular Velocidad)
- Creación de una variable pública velocidad para configurar la velocidad desde el Inspector.
- Obtención de los valores de los ejes horizontal y vertical mediante Input.GetAxis("Horizontal") e Input.GetAxis("Vertical").
- Detección de las teclas de dirección mediante Input.GetKey() y KeyCode.
- Cálculo del producto de la velocidad por los valores de ambos ejes.
<img width="1920" height="1080" alt="Ej6" src="https://github.com/user-attachments/assets/855d528e-9659-41c3-afe8-c1d2b9ae9b1d" />

## Hitos Ejercicio 7 (Mapear la tecla h)
- Acceso al Input Manager de Unity para modificar la configuración de los controles.
- Asociación de la tecla H a la función Disparo, modificando el mapeo correspondiente.
- Comprobación de que la función de disparo se activa al pulsar la tecla H.
<img width="1920" height="1080" alt="Ej7" src="https://github.com/user-attachments/assets/f8b40f45-574c-40a0-996e-f86e7a00a8a9" />

## Hitos Ejercicio 8 (Mover por dirección)
- Creación de un script asociado al cubo con las variables públicas moveDirection y speed, configurables desde el Inspector.
- Aplicación del movimiento mediante Transform.Translate(), utilizando el vector de dirección y la velocidad.
- Comprobación del efecto de duplicar las coordenadas del vector de dirección sobre el desplazamiento:
  El cubo se mueve el doble de distancia por unidad de tiempo.
- Comprobación del efecto de duplicar la velocidad manteniendo constante la dirección del movimiento:
  También se mueve el doble de rápido.
- Análisis del comportamiento del movimiento cuando la velocidad es inferior a 1:
  El movimiento es más lento.
- Observación de los cambios producidos al situar el cubo a una altura y > 0:
  El cubo parte desde una altura superior; el movimiento en Y se suma a esa posición.
- Comparación entre el movimiento relativo al sistema de referencia local y al sistema de referencia mundial:
  Al rotar el cubo, el movimiento cambia respecto a sus ejes locales o permanece respecto a los ejes mundiales.
<img width="1920" height="1080" alt="Ej8" src="https://github.com/user-attachments/assets/4c891d60-a885-47c6-8183-ca66f18d1e48" />

## Hitos Ejercicio 9 y 10 (Mover figuras)
- Creación de un script para controlar el movimiento del cubo mediante las flechas del teclado.
- Implementación del movimiento de la esfera mediante las teclas W, A, S y D.
- Utilización de Input.GetAxis() para obtener la entrada del teclado y de Transform.Translate() para desplazar los objetos según los ejes horizontal y vertical.
- Incorporación de Time.deltaTime al cálculo del desplazamiento, para dependender del tiempo transcurrido entre fotogramas.
<img width="1920" height="1080" alt="Ej9_10" src="https://github.com/user-attachments/assets/46d51cb9-3597-4157-a986-addbb5571381" />

## Hitos Ejercicio 11 (Mover el cubo a la esfera)
- Obtención del vector de dirección desde el cubo hasta la esfera mediante la diferencia entre sus posiciones.
- Normalización del vector de dirección mediante Vector3.normalized para evitar que la distancia entre los objetos afecte a la velocidad de avance.
- Restricción del movimiento al plano horizontal para mantener constante la altura del cubo.
<img width="1920" height="1080" alt="Ej11" src="https://github.com/user-attachments/assets/78ef7e0d-51a5-4fe0-8ffa-b88a821f2fed" />

## Hitos Ejercicio 12 (Moverse orientado a la esfera)
- Adaptación del movimiento anterior para que el cubo se oriente hacia la esfera antes de avanzar.
- Utilización de Transform.LookAt() para orientar el eje Z positivo del cubo hacia la esfera.
- Aplicación del desplazamiento en el espacio mundial para evitar que la orientación del sistema de referencia afecte incorrectamente al movimiento.
- Comprobación del comportamiento del cubo al cambiar la posición de la esfera mediante las teclas W, A, S y D.
<img width="1920" height="1080" alt="Ej12" src="https://github.com/user-attachments/assets/570360fc-4e76-4ecb-bdb8-9fce6b86107c" />

## Hitos Ejercicio 13 (Girar y Moverse hacia +z)
- Utilización de Input.GetAxis("Horizontal") para controlar el giro del objeto mediante las teclas de dirección horizontal.
- Aplicación de Transform.Rotate() para girar el objeto sobre el eje Y.
- Utilización de Transform.forward para obtener la dirección hacia delante según la orientación actual del objeto.
- Utilización de Debug.DrawRay() para visualizar la dirección del movimiento durante la depuración.
- Comprobación de que el objeto cambia su trayectoria al girar, avanzando siempre en la dirección hacia la que está orientado.
<img width="1920" height="1080" alt="Ej13" src="https://github.com/user-attachments/assets/b4ddf01a-cdbc-4483-9767-53be6dd95945" />


