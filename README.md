Se configura el proyecto en Visual Studio 2022 creando una aplicación Windows Forms y se ajustan las propiedades de la ventana principal: nombre, texto y dimensiones.
Se agregan los controles necesarios: un botón, tres TextBox y tres Label. Los Label se ubican a la izquierda de cada TextBox y el botón en la parte inferior.
Se configuran las propiedades de cada control. Los Label reciben su nombre y texto.
El primer TextBox queda para ingresar el valor. Los otros dos TextBox se dejan en modo ReadOnly para que el usuario no escriba en ellos. El botón recibe su nombre y texto correspondiente.
Se escribe el código declarando las variables lado, perimetro y area como Double.
Se agregan validaciones para evitar campos vacíos, valores no numéricos o números negativos. El cálculo del perímetro consiste en multiplicar el lado por 4, y el del área en multiplicar el lado por sí mismo.
Los resultados se muestran en los TextBox de salida. También se cambia el nombre del formulario de inicio en las propiedades para evitar errores de compilación.
Al compilar el proyecto, se obtiene un programa funcional en Windows Forms que calcula el perímetro y el área de un cuadrado según el valor del lado ingresado.

<img width="347" height="317" alt="image" src="https://github.com/user-attachments/assets/856d1e1d-68f6-4ee0-967b-a6c374bb6a05" />
