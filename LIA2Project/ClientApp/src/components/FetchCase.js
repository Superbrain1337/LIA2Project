import { RouteComponentProps } from 'react-router';
import { Link, NavLink } from 'react-router-dom';
import React, { Component } from 'react';


export class FetchCase extends Component {
    constructor(props) {
        super(props);
        this.state = { empList: [], loading: true };

        fetch('api/Cases/Index')
            .then(response => response.json())
            .then(data => {
                this.setState({ empList: data, loading: false });
            });

        // This binding is necessary to make "this" work in the callback  
        this.handleDelete = this.handleDelete.bind(this);
        this.handleEdit = this.handleEdit.bind(this);

    }

    
    // Handle Delete request for a case  
    handleDelete(id) {
        if (window.confirm("Do you want to delete case with Id: " + id))
            return;
        else {
            fetch('api/Cases/Delete/' + id, {
                method: 'delete'
            }).then(data => {
                this.setState(
                    {
                        empList: this.state.empList.filter((rec) => {
                            return (rec.CaseId !== id);
                        })
                    });
            });
        }
    } 

    handleEdit(id) {
        this.props.history.push("/cases/edit/" + id);
    }

    // Returns the HTML table to the render() method.  
    renderCaseTable(empList) {
        return (
            <table className='table'>
                <thead>
                    <tr>
                        <th></th>
                        <th>CaseId</th>
                        <th>CaseName</th>
                    </tr>
                </thead>
                <tbody>
                    {empList.map(emp =>
                        (<tr key={emp.caseId}>
                            <td></td>
                            <td>{emp.caseId}</td>
                            <td>{emp.caseName}</td>
                            <td>
                                <a className="action" onClick={(id) => this.handleEdit(emp.CaseId)}>Edit</a>  |
                            <a className="action" onClick={(id) => this.handleDelete(emp.CaseId)}>Delete</a>
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
            : this.renderCaseTable(this.state.empList);

        return (<div>
            <h1>Case Data</h1>
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
}    