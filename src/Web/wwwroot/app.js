import {HttpClient} from 'aurelia-http-client';
//import {HttpClient} from 'aurelia-fetch-client';

export class App {
    constructor() {
        this.message = 'Welcome to Aurelia!';
    }
    
    buscar(){

        let client = new HttpClient();
        client.get('http://localhost:56567/api/candidato')
            .then(data => {
              console.log(data);
          })
        .catch(function(error) {
            console.log(error.json());
        });



        /*
        let client = new HttpClient();
        client.configure(config => {
            config.withBaseUrl('http://localhost:56567/api/').withDefaults({
                headers: {
                    'Accept': 'application/json',
                    'Content-type' : 'application/json'
                }
            }).withInterceptor({
                response: handleResponse
            });
        });

        client.fetch('candidato')
            .then(function(response) {
                if (response.status >= 200 && response.status < 300) {
                    return response;
                } else {
                    var error = new Error(response.statusText);
                    error.response = response;
                    throw error;
                }
            })
          .then(response => response.json())
          .then(data => {
              console.log(data);
          })
        .catch(function(error) {
            console.log(error);
        })
        ;
        */
    }

}

function handleResponse(response) {
    if (!response.ok) {
        response.json().then(data => {
            return {status: response.status, data: data};
        });
    }
}