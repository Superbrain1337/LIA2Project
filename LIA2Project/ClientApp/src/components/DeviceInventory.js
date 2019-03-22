import { RouteComponentProps } from 'react-router';
import { Link, NavLink } from 'react-router-dom';
import React, { Component } from 'react';


export class DeviceInventory extends Component {
    constructor(props) {
        super(props);
        this.state = { loading: true, inventory: new InventoryData, inventory2: new InventoryData };

        

    }

    componentWillMount() {
        var inventoryID = this.props.match.params["inventoryId"];

        fetch("api/Inventory/" + inventoryID)
            .then(response => response.json())
            .then(data => (
                this.setState({
                    inventory: data,
                    loading: false
                })
            ));
    }

    renderDeviceInfoTable() {
        console.log(this.state.inventory);
        return (
            <table className='table'>
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Group</th>
                        <th>Name</th>
                        <th>Description</th>
                        <th>Type</th>
                        <th>Location</th>
                        <th>Supplier</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>{this.state.inventory.inventoryId}</td>
                        <td>{this.state.inventory.inventoryGroup}</td>
                        <td>{this.state.inventory.inventoryName}</td>
                        <td>{this.state.inventory.inventoryDescription}</td>
                        <td>{this.state.inventory.inventoryType}</td>
                        <td>{this.state.inventory.inventoryLocation}</td>
                        <td>{this.state.inventory.inventorySupplier}</td>
                    </tr>

                </tbody>
            </table>
        );

    }
    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderDeviceInfoTable();

        return (<div>
            <h1>Device Data</h1>
            {contents}
        </div>);
    }
}

export class InventoryData {
    inventoryId = 0;
    inventoryGroup = "";
    inventoryName = "";
    inventoryDescription = "";
    inventoryType = 0;
    inventoryLocation = "";
    inventorySupplier = "";
}