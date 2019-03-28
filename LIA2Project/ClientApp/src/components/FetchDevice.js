import { RouteComponentProps } from 'react-router';
import { Link, NavLink } from 'react-router-dom';
import React, { Component } from 'react';


export class FetchDevice extends Component {
    constructor(props) {
        super(props);
        this.state = { devList: [], cscList: [], loading: true };

        fetch('api/Devices/Index')
            .then(response => response.json())
            .then(data => {
                this.setState({ devList: data, loading: false });
            });

        fetch('api/Casecontacts/Index')
            .then(response => response.json())
            .then(data => {
                this.setState({ cscList: data, loading: false });
            });
    }

    componentDidMount() {
        if (sessionStorage.getItem('loggedIn') !== 'true') {
            this.props.history.push("/userlogin");
        }
    }

    handleEdit(id) {
        this.props.history.push("/devices/edit/" + id);
    }

    handleRedirect(redirect, id) {
        if (redirect === "Inventory") {
            this.props.history.push("/inventory/" + id);

        }
    }

    renderCaseDeviceTable(devList, cscList) {
        return (
            <table className='table'>
                <thead>
                    <tr>
                        <th>Device id</th>
                        <th>Case id</th>
                        <th>Group/Domain</th>
                        <th>Name</th>
                        <th>Name</th>
                    </tr>
                </thead>
                <tbody>
                    {devList.map(dev =>
                        (<tr key={dev.caseDeviceId}>
                            <td>{dev.caseDeviceId}</td>
                            <td>{dev.caseId}</td>
                            <td>{dev.caseDeviceGroup}</td>
                            <td onClick={() => this.handleRedirect("Inventory", dev.caseDeviceInventoryId)}>{dev.caseDeviceName}</td>
                        </tr>)
                    )}

                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderCaseDeviceTable(this.state.devList, this.state.cscList);

        return (<div>
            <h1>Device Data</h1>
            <p>This component demonstrates fetching device data from the server.</p>
            {contents}
        </div>);
    }
}

export class DeviceData {
    CaseDeviceId = 0;
    CaseId = 0;
    CaseDeviceGroup
    CaseDeviceName = "";
    caseDeviceInventoryId
}
export class UsersData {
    UserTelephone = "";
}
export class CaseContacts {
    CaseId = 0;
    CaseContactId = 0;
    CaseContactNotify = true;
    CaseContactName = "";
    CaseContactGroup = "";
}
