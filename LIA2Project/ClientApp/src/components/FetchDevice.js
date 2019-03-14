import { RouteComponentProps } from 'react-router';
import { Link, NavLink } from 'react-router-dom';
import React, { Component } from 'react';


export class FetchDevice extends Component {
    constructor(props) {
        super(props);
        this.state = { empList: [], loading: true };

        fetch('api/Devices/Index')
            .then(response => response.json())
            .then(data => {
                this.setState({ empList: data, loading: false });
            });

    }

    handleEdit(id) {
        this.props.history.push("/devices/edit/" + id);
    }

    renderCaseDeviceTable(empList) {
        return (
            <table className='table'>
                <thead>
                    <tr>
                        <th>Device id</th>
                        <th>Case id</th>
                        <th>Group/Domain</th>
                        <th>Name</th>
                    </tr>
                </thead>
                <tbody>
                    {empList.map(emp =>
                        (<tr key={emp.caseDeviceId}>
                            <td>{emp.caseDeviceId}</td>
                            <td>{emp.caseId}</td>
                            <td>{emp.caseDeviceName}</td>
                            <td>{emp.caseDeviceGroup}</td>
                        </tr>)
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderCaseDeviceTable(this.state.empList);

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
    CaseDeviceName: "";
}
export class UsersData {
    UserTelephone = "";
}
