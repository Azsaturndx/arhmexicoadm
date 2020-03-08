# Cookie-Alert

Cookie-Alert es un m�dulo JS que te permite agregar sin esfuerzo el mensaje de informaci�n de utilizaci�n de Cookies.
  - Puedes establecer personalizaci�n a tu medida.
  - En caso requerido es posible hacer alteraciones muy personalizadas por CSS, o por inyecci�n de datos al DOM.
  - Apegado al RGPD (Reglamento General de Protecci�n de Datos)
  - Una vez que el usuario acepta, no se le vuelve a molestar, gracias a una Cookie.

### The Cookie Law
> Almost all websites use cookies � little data files �
> to store information in peoples� web browsers.
> Some websites contain hundreds of them.

*source:https://www.cookielaw.org/the-cookie-law/*


### Requerimientos

Cookie-Alert necesita las siguientes librer�as para su correcto funcionamiento:
* [jQuery] - lightweight, "write less, do more", JavaScript library

** Cookie-Alert necesita una clave de licencia que puede ser comprada en:

### Instalaci�n


1.- Agrega JQuery a tu sitio antes de finalizar la etiqueta Body.

```html
<body>
    ...
    <script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
</body>
```

2.- Inmediatamente despu�s, agrega el elemento:

```html
<script
    src="https://www.intellistream.net/products/cookie-alert/cookie-alert.js"
    id="cookieinfo"
    data-license-key="{{TU_CLAVE_DE_PRODUCTO}}">
```

3.- Agrega tus personalizaciones al mismo elemento:

```html
<script
    src="https://www.intellistream.net/products/cookie-alert/cookie-alert.js"
    id="cookieinfo"
    data-license-key="{{TU_CLAVE_DE_PRODUCTO}}"
    data-message="Usamos Cookies para mejorar tu experiencia de usuario..."
    data-moreinfo="https://wikipedia.org/wiki/HTTP_cookie"
    data-linkmsg="Leer m�s"
    data-close-text="Acepto usar las Cookies."
    data-bg="#44344F"
    data-fg="#93D4F0"
    data-divlinkbg="#564D80"
    data-link="#fff"
    data-divlink="#C2F970"
    data-height="40px"
    data-effect="fade"
    data-font-size="20px"
    data-font-family="Roboto"
    data-cookie="mi-cookie-personalizada"
    data-expires="Fri, 31 Dec 9999 23:59:59 GMT"
    data-text-align="center"
    data-mask=true
    data-mask-opacity=0.5
    data-mask-background="#564D80"
>
```


### Personalizaciones

Las personalizaciones son totalmente opcionales; Cookie-Alert tiene un tema por defecto que luce bien en cualquier sitio.
Sin embargo, para ser �til en todas tus p�ginas, Cookie-Alert permite las siguientes personalizaciones:
#### General
| Propiedad | Descripci�n | Ejemplo |
| ------ | ------ | ------ |
| data-license-key | Clave de producto |  "1234-5678-9123-4567" |
| data-message | Mensaje principal | "Usamos Cookies para mejorar tu experiencia de usuario..." |
| data-height | Tama�o del aviso | "30px" |
| data-bg | Color compatible CSS3 para el fondo del aviso | "#44344F" |
| data-fg | Color compatble CSS3 para la fuente del aviso | "#93D4F0" |
| data-effect | Efecto de aparici�n | "fade" |
| data-font-size | Tama�o de fuente General | "14px" |
| data-font-family | Tipograf�a | "Roboto" |


#### Bot�n Ver m�s
| Propiedad | Descripci�n | Ejemplo |
| ------ | ------ | ------ |
| data-linkmsg | Mensaje de bot�n "Ver m�s" | "M�s informaci�n" |
| data-moreinfo | Enlace de bot�n "Ver m�s" | "https://wikipedia.org/wiki/HTTP_cookie" |
| data-link | Color compatible CSS3 de la letra del bot�n "Ver m�s"  | "#FFF" |


#### Bot�n Aceptar
| Propiedad | Descripci�n | Ejemplo |
| ------ | ------ | ------ |
| data-close-text | Mensaje del bot�n de "Aceptar" | "Acepto" |
| data-divlink | Color de texto del bot�n "Aceptar" | "#FFF" |

### Cookie para evitar preguntar m�ltiples veces
| Propiedad | Descripci�n | Ejemplo |
| ------ | ------ | ------ |
| data-cookie | Nombre de Cookie de "Aceptar" | "mi-cookie-personalizada" |
| data-expire | Fecha de expiraci�n de "Cookie" | "Fri, 31 Dec 9999 23:59:59 GMT" |

### Overlay para ocultar el contenido
| Propiedad | Descripci�n | Ejemplo |
| ------ | ------ | ------ |
| data-mask | para difumidar u ocultar el contenido* | true |
| data-mask-opacity | Opacidad del overlay | 0.5 |
| data-mask-background | Color de fondo del Overlay | "#564D80" |

**Si se elige esta opci�n el hacer click en cualquier lugar del Overlay se tomar� como Aceptaci�n del usuario.*


#### Utilizaci�n

Cookie-Alert se autoejecuta al iniciar el sitio, si el usuario ya ha aceptado el aviso no se le vuelve a molestar hasta
cumplirse la fecha de la cookie.
