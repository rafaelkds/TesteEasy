import {HttpClient, json} from 'aurelia-fetch-client';

export class Client {
    
    get(recurso) {
        return new Promise(
            function(resolve, reject) {
                let client = criar();
                client.fetch(recurso)
                    .then(response => tratarResposta(response, resolve, reject));
            }
        );
    }

    post(recurso, dados) {
        return new Promise(
            function(resolve, reject) {
                let client = criar();
                client.fetch(recurso, {
                    method: 'POST',
                    body: json(dados)
                })
                    .then(response => tratarResposta(response, resolve, reject));
            }
        );
    }

    delete(recurso) {
        return new Promise(
            function(resolve, reject) {
                let client = criar();
                client.fetch(recurso, {
                    method: 'DELETE'
                })
                    .then(response => tratarResposta(response, resolve, reject));
            }
        );
    }

    put(recurso, dados) {
        return new Promise(
            function(resolve, reject) {
                let client = criar();
                client.fetch(recurso, {
                    method: 'PUT',
                    body: json(dados)
                })
                    .then(response => tratarResposta(response, resolve, reject));
            }
        );
    }
}

function criar(){
    let client = new HttpClient();
    client.configure(config => {
        config.withBaseUrl('http://localhost:56567/api/');
    });
    return client;
}

function tratarResposta(response, resolve, reject){
    
        response.json().then(data => {
            let retorno = {
                status: response.status,
                data: data
            };
            if(response.ok)
                resolve(retorno);
            else
                reject(retorno);
        })
        .catch(() => {
            let retorno = {
                status: response.status,
                data: null
            };
            if(response.ok)
                resolve(retorno);
            else
                reject(retorno);
        })
    
}