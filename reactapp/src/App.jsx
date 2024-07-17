import React, { Component } from 'react';
import ContribuyenteService from '../src/services/contribuyenteService';

export default class App extends Component {
    static displayName = App.name;
    service = new ContribuyenteService();

    constructor(props) {
        super(props);
        this.state = {
            loading: true,
            listNCF: [],
            selectedContribuyente: {},
            contribuyentesList: []
        };
    }

    // Create our number formatter.
    formatter = new Intl.NumberFormat('en-US', {
        style: 'currency',
        currency: 'USD'
    });

    seleccionarContribuyente(contribuyente) {
        this.service.getNCFs(contribuyente.id)
            .then(response => {
                this.setState({
                    ...this.state,
                    listNCF: response,
                    selectedContribuyente: contribuyente
                });
            });
    }

    componentDidMount() {
        this.service.getContribuyentes()
            .then(response => {
                this.setState({
                    ...this.state,
                    contribuyentesList: response,
                    loading: false
                });
            });
    }

    render() {
        return this.state.loading ? <h1>Cargando...</h1> : (
            <div className="container">
                <p></p>
                <h1>Sistema de consulta de contribuyentes</h1>
                <hr></hr>
                <div className="row">
                    <div className="col contribuyentes">
                        <table className="table">
                            <thead>
                                <tr>
                                    <th>RNC/C&eacute;dula</th>
                                    <th>Nombre</th>
                                    <th>Tipo</th>
                                    <th>Estatus</th>
                                </tr>
                            </thead>
                            <tbody>
                                {this.state.contribuyentesList.map(p =>
                                    <tr key={p.rncCedula} className={p.rncCedula == this.state.selectedContribuyente.rncCedula ? "fila table-primary" : "fila"}
                                        onClick={() => { this.seleccionarContribuyente(p) }}>
                                        <td>{p.rncCedula}</td>
                                        <td>{p.nombre}</td>
                                        <td>{p.tipo}</td>
                                        <td>{p.estatus}</td>
                                    </tr>
                                )}
                            </tbody>
                        </table>
                    </div>

                    <div className="col ncfs">
                        <table className="table table-striped">
                            <thead>
                                <tr>
                                    <th>NCF</th>
                                    <th>Monto</th>
                                    <th>Itebis(18%)</th>
                                </tr>
                            </thead>
                            <tbody>
                                {this.state.listNCF && this.state.listNCF.map(p =>
                                    <tr key={p.ncf}>
                                        <td>{p.ncf}</td>
                                        <td>{this.formatter.format(p.monto)}</td>
                                        <td>{this.formatter.format(p.itebis18)}</td>
                                    </tr>
                                )}
                            </tbody>
                            <tfoot>
                                <tr>
                                    <th>Total</th>
                                    <td></td>
                                    <th>{this.state.listNCF
                                        &&
                                        this.formatter.format(Math.round((this.state.listNCF
                                            .map(p => p.itebis18)
                                            .reduce((acumulador, valorActual) => { return acumulador + valorActual; }, 0) + Number.EPSILON) * 100) / 100)}</th>
                                </tr>
                            </tfoot>
                        </table>
                    </div>
                </div>
            </div>
        );
    }
}
