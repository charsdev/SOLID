# S Single Responsibility Principle 
# «Un objeto debería tener una, y sólo una única razón para cambiar»

En este ejemplo tenemos una clase factura y una clase producto que tienen una relacion entre ellos a través de una clase asociativa llamada item.
Por otra parte la clase factura tiene la responsabilidad de obtener el total de todos los items contenidos y a su vez contiene el detalle del cliente.
Aqui podemos ver como se viola el principio de Responsabilidad unica teniendo la clase factura muchas responsabilidades con una baja cohesion. 

Aplicando la S de SOLID realizamos una refactorización sobre el código:

1. Creamos una clase llamada cliente, el cual contendra su propio detalle con el cual de esta manera relacionamos la clase cliente con nuestra factura.

2. Modificamos la clase item para que tenga la responsabilidad de obtener su propio subtotal parcial al multiplicar la cantidad del item por el precio del producto. 

3. En el metodo que obtiene el total de nuestra factura realizamos que el resultado sea la sumatoria de todos los subtotales de los items contenidos.

De esta manera logramos obtener una alta cohesion y un bajo acoplamiento en nuestro programa al delegar las responsabilidades que previamente estaban en la 
factura entre las clases de cliente e item. 

-----------------------------------------------------------------------------------------------------------------------------------------------------------------

# O Open Closed Principle
# «un módulo de software debería estar abierto a extensión pero cerrado a modificación»

En este ejemplo tenemos una clase llamada Documento Contable el cual contendra de si misma un atributo llamado tipo,
este mismo tendra una relacion de uso a un enumerador llamado "Tipo Documento Contable", que afectara a la funcion de descripción de la clase "Documento Contable"
Aqui podemos ver como se viola el principio de abierto y cerrado, puesto que cada vez que querramos agregar un nuevo tipo deberemos modificar tanto el enumerador 
como la funcion de descripción de nuestra clase Documento contable para poder reaccionar ante el nuevo tipo agregado.

Aplicando O de SOLID realizamos la siguiente refactorización sobre el código:

1. Convertimos la clase "Documento Contable" de concreta a abstracta

2. Removemos la relacion de uso con el enumerador "Tipo de Documento Contable"

3. Creamos nuevas clases concretas por cada tipo requerido y a cada uno de lo extendemos de nuestra clase abstracta "Documento Contable"

4. Cada una de estas nuevas clases contendra dentro de si misma una funcion descripción el cual sobreescribira el comportamiento del documento contable en base a
su tipo.

De esta manera es mucho mas sencillo mantener en el tiempo el código realizado ante nuevos tipos en el futuro al hacer uso de la extension de una clase abstracta 
en vez de depender un enumerador.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------

# L Liskov Sustitution Principle 
# «Los objetos de un programa deberían ser intercambiables por instancias de sus subtipos sin alterar el correcto funcionamiento del programa»

En este ejemplo tenemos una clase impresora que nos permitira imprimir la descripción de cada una de nuestras clases que extienden de nuestra
siguiente clase llamada Documento Contable, las cuales son Nota de credito, Factura y Remito, donde esta ultima modifica el comportamiento de la operacion descripción al mostrarnos la cantidad de bultos.
Esto ultimo viola el princpio de sustitución de Liskov al sobreescribir el comportamiento de la clase que implementa. 

Aplicando L de SOLID realizamos la siguiente refactorización sobre el código:

1. Removemos la extension de la clase Remito a Documento Contable, dejandonos solo 3 clases con extension a Documento contable (Nota credito, Factura y Nota Debito)
2. Agregamos los atributos que estabamos heredando previamente de documento contable.
3. Modificamos nuestra clase impresora para que en vez de tener un metodo por cada tipo, sencillamente tengamos un metodo que tome en cuenta la clase padre del cual
 extienden.
4. Agregamos un nuevo metodo para la impresion del remito dado que ahora no tiene una clase padre del cual extender.

Con esto podemos asegurarnos que estamos cumpliendo el principio de sustitución de liskov al no alterar el correcto funcionamiento de nuestro programa, dado que
aunque remito comparta varios atributos con Documento Contable, remito hace referencia a un tipo de documento distinto
(compararse con pato de hule y el animal pato, comparten aspectos pero no son lo mismo)

-----------------------------------------------------------------------------------------------------------------------------------------------------------------

# I Interface Segregation Principle 
# «Los objetos no deberían verse forzados a depender de interfaces que no utilizan»

Este ejemplo contiene una clase Documento del cual implementan otras 2 clases llamadas Factura y factura electronica.
La clase Documento contiene 2 metodos llamado imprimir y enviar por mail.
Una factura no se puede enviar por mail dado que esta tiene ser presentada unicamente de manera fisica, esto viola el principio de segregacion de interfaces 
al forzar la implementacion del envio por mail cuando este mismo no lo requiere. 

Aplicando I De SOLID realizamos la siguiente refactorización sobre el código:

1. Creamos 2 interfaces que utilizaremos para segregar las operaciones que queremos realizar, IImprimible e IEmaileable
2. Ahora extendemos nuestra clase Documento de IImprimible e implementamos su interfaz como un metodo abstracto que posteriormente definiran Factura y 
Factura Electronica.
3. Ahora en nuestra clase Factura Electronica implementamos la interfaz de IEmaileable.

De esta manera logramos segregar las operaciones de impresion y de enviar por correo electronico utilizando la extension de una clase abstracta como lo es documento 
y la implementacion en una clase hija como lo es factura electronica. Evitando asi forzar la implementacion de una interfaz que no se utiliza.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------

# D Dependency Inversion Principle
# «Los módulos de alto nivel no deberían depender de los módulos de bajo nivel. Ambos deberían depender de abstraccionen»
# «Las abstracciones no deberían depender de los detalles. Los detalles deben depender de abstracciones.»

En este principio lo que tratamos de hacer desacoplar nuestro codigo invertir las dependencias que tenemos.

En este ejemplo una impresora que podra imprimir multiples tipos de documentos como lo son los documentos contables del cual extienden Nota de Credito y Factura
Recibo de sueldo, impuesto del cual extienden Factura de luz y Municipal, y un Remito. Todas estas clases podran ser impresas por nuestra clase impresora teniendo 
dentro de ellas un metodo por cada uno de las clases previamente indicadas 

Aplicando D de SOLID realizamos la siguiente refactorización sobre el código

1. Creamos una interfaz llamada IImprimible con la operacion de imprimir
2. Hacemos que todos los documentos que queriamos imprimir implementen la interfaz IImprimible, con esto cada documento sabra como imprimirse a partir del uso 
de la interfaz.
3. Reemplazamos todos los metodos dentro de la impresora que utilizaban la dependencia de los tipos de documentos, por un solo metodo Imprimir que tome 
tome como parametro objeto que implemente la interfaz IImprimible, dentro de la misma llamaremos la operacion imprimir del objeto pasado. 

De esta manera logramos invertir las dependencias de nuestro programa al hacer que los modulos de alto nivel (la Impresora) dependa de una abstración (IImprimible)
y el detalle de las operaciones (Imprimir) sean dadas por la implementacion de su interfaz. 