import React, { Component } from 'react';
import { Redirect } from 'react-router-dom';

const customStyles = {
    content: {
        top: '50%',
        left: '60%',
        right: '30%',
        bottom: 'auto',
        marginRight: '-50%',
        transform: 'translate(-50%, -50%)'
    }
};

export class Home extends Component {
    displayName = Home.name
    constructor(props) {
        super(props);
        this.state = { caseList: [], devList: [], loading: true };

        fetch('api/Cases/GetRecent')
            .then(response => response.json())
            .then(data => {
                this.setState({ caseList: data, loading: false });
            });
        
    }

    isUserLoggedIn() {
        if (sessionStorage.getItem('loggedIn') !== 'true') {
            return <p>You need to log in to see your cases</p>;
        } else {
            return this.state.loading
                ? <p><em>Loading...</em></p>
                : this.renderCaseTable(this.state.caseList, this.state.devList);
        }
    }


    renderCaseTable(caseList, devList) {

        console.log("renderCaseTable");


        return (
            <table className='table' id="caseTable">
                <thead>
                    <tr className="notfirst">
                        <th></th>
                        <th>Case Id</th>
                        <th>Case Name</th>
                        <th>Case Description </th>
                        <th>Case Notes</th>
                        <th>Created by </th>
                        <th>Reported by </th>
                        <th>Case Type</th>
                        <th>Case Status</th>
                    </tr>
                </thead>
                <tbody>
                    {caseList.map(emp =>
                        (<tr key={emp.caseId}>
                            <td></td>
                            <td> {emp.caseId}</td>
                            <td>{emp.caseName}</td>
                            <td>{emp.caseDescription}</td>
                            <td>{emp.caseNotes}</td>
                            <td>{emp.caseCreatedUser}</td>
                            <td>{emp.caseReportedBy}</td>
                            <td>{emp.caseType}</td>
                            <td>{emp.caseStatus}</td>
                            

                        </tr>))}
                </tbody>
            </table>
        );
    }

    
    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderCaseTable(this.state.caseList, this.state.devList);
        return (
            
            <div>
                <h1>Welcome to DuoSTATION servicedesk! Å Ä Ö</h1>
                <p>Here you can register new cases an search in our knowledgebase.</p>
                <p> To logon to this service, you must be a customer and been assigned an account and password. </p>
                <hr />
                <h2>My most recent cases</h2>
                {this.isUserLoggedIn()}
                <hr />
                <h2>Information</h2>
                
            
            
        </div>);
    }
}
