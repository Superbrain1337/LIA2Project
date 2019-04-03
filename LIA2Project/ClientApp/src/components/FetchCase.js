import { RouteComponentProps } from 'react-router';
import { Link, NavLink } from 'react-router-dom';
import React, { Component } from 'react';
import { UserData } from './UserLogin';


export class FetchCase extends Component {
    constructor(props) {
        super(props);
        this.state = { pageName: 'fetchcase' ,caseList: [], loading: true };

        fetch('api/Cases/Index')
            .then(response => response.json())
            .then(data => {
                this.setState({ caseList: data, loading: false });
            });
        // This binding is necessary to make "this" work in the callback  
        this.handleDelete = this.handleDelete.bind(this);
        this.handleEdit = this.handleEdit.bind(this);

    }

    componentDidMount() {
        if (sessionStorage.getItem('loggedIn') !== 'true') {
            this.props.history.push("/userlogin");
        }
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
                        caseList: this.state.caseList.filter((rec) => {
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
    renderCaseTable(caseList) {

        console.log("renderCaseTable");


        return (
            <table className='table'>
                <thead>
                    <tr>
                        <th></th>
                        <th>Case Id</th>
                        <th>Case Name</th>
                        <th>Case Description </th>
                        <th>Created by </th>
                        <th>Reported by </th>
                    </tr>
                </thead>
                <tbody>
                    {caseList.map(emp =>
                        (<tr key={emp.caseId}>
                            <td></td>
                            <td>{emp.caseId}</td>
                            <td>{emp.caseName}</td>
                            <td>{emp.caseDescription}</td>
                            <td>{emp.caseCreatedUser}</td>
                            <td>{emp.caseReportedBy}</td>
                            <td>
                                <a className="action" onClick={(id) => this.handleEdit(emp.caseId)}>Edit</a> |
                                <a className="action" onClick={(id) => this.handleDelete(emp.caseId)}>Delete</a>
                            </td>

                        </tr>))}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderCaseTable(this.state.caseList);

        let username = sessionStorage.getItem('userName');

        return (<div>
            <h1>Case Data</h1>
            <p>This component demonstrates fetching Case data from the server.</p>
            <p>The logged in user is --- {username} ---</p>
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