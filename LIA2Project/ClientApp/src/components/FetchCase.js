import { RouteComponentProps } from 'react-router';
import { Link, NavLink } from 'react-router-dom';
import React, { Component } from 'react';


export class FetchCase extends Component {
    constructor(props) {
        super(props);
        this.state = { empList: [], usrList: [], loading: true };

        fetch('api/Cases/Index')
            .then(response => response.json())
            .then(data => {
                this.setState({ empList: data, loading: false });
            });

        fetch('api/Users/Index')
            .then(response => response.json())
            .then(data => {
                this.setState({ usrList: data, loading: false });
            });
        // This binding is necessary to make "this" work in the callback  
        this.handleDelete = this.handleDelete.bind(this);
        this.handleEdit = this.handleEdit.bind(this);

    }

    
    // Handle Delete request for a case  
    handleDelete(id) {
        if (!window.confirm("Do you want to delete case with Id: " + id))
            return;
        else {
            fetch('api/Cases/Delete/' + id, {
                method: 'delete'
            }).then(data => {
                this.setState(
                    {
                        empList: this.state.empList.filter((rec) => {
                            return (rec.caseId !== id);
                        })
                    });
            });
        }
    } 

    handleEdit(id) {
        this.props.history.push("/cases/edit/" + id);
    }

    // Returns the HTML table to the render() method.  
    renderCaseTable(empList, usrList) {
        return (
            <table className='table'>
                <thead>
                    <tr>
                        <th></th>
                        <th>Case Id Å Ä Ö</th>
                        <th>Case Name</th>
                        <th>Case Description </th>
                        <th>Created by </th>
                        <th>Reported by </th>
                        <th>Telephone</th>
                    </tr>
                </thead>
                <tbody>
                    {empList.map(emp =>
                        (<tr key={emp.caseId}>
                            <td></td>
                            <td>{emp.caseId}</td>
                            <td>{emp.caseName}</td>
                            <td>{emp.caseDescription}</td>
                            <td>{emp.caseCreatedUser}</td>
                            <td>{emp.caseReportedBy}</td>
                            <td> {usrList.map(usr =>
                                (
                                    <td>{usr.userTelephone}</td>
                                )
                            )}</td>
                            <td>
                                <a className="action" onClick={(id) => this.handleEdit(emp.caseId)}>Edit</a>  |
                            <a className="action" onClick={(id) => this.handleDelete(emp.caseId)}>Delete</a>
                            </td>
                        </tr>)
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderCaseTable(this.state.empList, this.state.usrList);

        return (<div>
            <h1>Case Data Å Ä Ö</h1>
            <p>This component demonstrates fetching Case data from the server.</p>
            <p>
                <Link to="/addcase">Create New</Link>
            </p>
            {contents}
        </div>);
    }
}

export class CaseData {
    caseId = 0;
    caseName = "";
    caseDescription
    caseCreatedUser
    caseReportedBy
}    
export class UsersData {
    UserLoginName = "";
    UserTelephone = "";
}