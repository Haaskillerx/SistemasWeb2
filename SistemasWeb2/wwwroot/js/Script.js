
/*
 *     function SendData(ids)
    {
        var data = JSON.stringify(ids);

        fetch(urlOrdenar, {
            method: 'POST',
            body: data,
            headers: {
                'Content-Type' : 'application/json'
            }
        }).then(response => response.json())
            .catch(error => console.error('Error:', error))
            .then(response => console.log('Success:', response));

    }
    */

var test = 1;

function Serializado(data) {
    let obj = {};
    for (let [key, value] of data) {
        if (obj[key] !== undefined) {
            if (!Array.isArray(obj[key])) {
                obj[key] = [obj[key]];
            }
            obj[key].push(value);
        } else {
            obj[key] = value;
        }
    }
    return obj;
}

class Categorias {



    alerta() { alert("Funcion dentro de clase."); }


    FetchApi() {

        // Get the form
        let form = document.querySelector('#formulario_categoria');
        // Get all field data from the form
        let formData = new FormData(form);
        // Convert to an object
        //let formObj = Serializado(data);
        let postData = new FormData();
        // Display the key/value pairs
        for (var pair of formData.entries()) {
            //console.log(pair[0] + ', ' + pair[1]);
            postData.append(pair[0], pair[1]);
        }
        
        let _data = {
            test1: "foo",
            test2: "bar",
            test3: 1
        };
        
        var urlPost = 'GetCategorias';
        fetch(urlPost,
            {
                method: 'POST',
                body: JSON.stringify({
                    Nombre: "aa",
                    Descripcion: 'test'
                }),
                headers:{ "Content-type": "application/json; charset=UTF-8" }
            })//.then(response => response.json())
            .catch(error => console.error('Error:', error))
            .then(response => console.log('Success:', response.text));


        //FIN DEL AJAX NATURAL


    }



}

//INSTANCIA DE CLASE
var objetoJS = new Categorias();