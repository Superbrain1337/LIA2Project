import { RouteComponentProps } from 'react-router';
import { Link, NavLink } from 'react-router-dom';
import React, { Component } from 'react';


export class FetchDevice extends Component {
    constructor(props) {
        super(props);
        this.state = { empList: [], cscList: [], loading: true };

        fetch('api/Devices/Index')
            .then(response => response.json())
            .then(data => {
                this.setState({ empList: data, loading: false });
            });

        fetch('api/Casecontacts/Index')
            .then(response => response.json())
            .then(data => {
                this.setState({ cscList: data, loading: false });
            });


    }

    handleEdit(id) {
        this.props.history.push("/devices/edit/" + id);
    }

    renderCaseDeviceTable(empList, cscList) {
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
                    {empList.map(emp =>
                        (<tr key={emp.caseId}>
                            <td>{emp.caseDeviceId}</td>
                            <td>{emp.caseId}</td>
                            <td>{emp.caseDeviceGroup}</td>
                            <td>{emp.caseDeviceName}</td>
                            {cscList.map(csc =>
                                (
                                    <td>{csc.caseContactGroup}</td>
                                )
                            )}
                        </tr>)
                    )}
                    
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderCaseDeviceTable(this.state.empList, this.state.cscList);

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
