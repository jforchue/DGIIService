class ContribuyenteService {

    getContribuyentes() {
        return fetch('api/contribuyentes')
            .then(response1 => {
                return response1.json();
            })
            .then(data => {
                return data;
            });
    }

    getNCFs(id) {
        return fetch('api/contribuyentes', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json' // Set the headers
            },
            body: JSON.stringify(id)
        }).then(response1 => {
            return response1.json();
        }).then(data => {
            return data;
        });
    }
}

export default ContribuyenteService;