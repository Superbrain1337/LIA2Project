﻿import { RouteComponentProps } from 'react-router';
import { Link, NavLink } from 'react-router-dom';
import React, { Component } from 'react';
import Modal from 'react-modal';

const customStyles = {
    content: {
        top: '50%',
        left: '50%',
        right: 'auto',
        bottom: 'auto',
        marginRight: '-50%',
        transform: 'translate(-50%, -50%)'
    }
};


export class FetchCase extends Component {
    constructor(props) {
        super(props);
        this.state = { empList: [], usrList: [], loading: true, modalIsOpen: false, x: 0 };


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
        this.openModal = this.openModal.bind(this);
        this.afterOpenModal = this.afterOpenModal.bind(this);
        this.closeModal = this.closeModal.bind(this);
    }

    openModal(input, input2, input3, input4, input5, input6, input7) {
        this.setState({ modalIsOpen: true, x: input, xcaseName: input2, xcaseDescription: input3, xcaseCreatedUser: input4, xcaseReportedBy: input5, xuserTelephone: input6, xcaseType : input7 });
    }

    afterOpenModal() {
        // references are now sync'd and can be accessed.
        this.subtitle.style.color = '#f00';
    }

    closeModal() {
        this.setState({ modalIsOpen: false });
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

            <table className='table' id="caseTable">
                <thead>
                    <tr>
                        <th></th>
                        <th>Case Id</th>
                        <th>Case Name</th>
                        <th>Case Description </th>
                        <th>Created by </th>
                        <th>Reported by </th>
                        <th>Telephone</th>
                        <th>Case Type</th>
                    </tr>
                </thead>
                <tbody>
                    {empList.map(emp =>
                        (<tr key={emp.caseCreatedUser} onClick={() => this.openModal(emp.caseId, emp.caseName, emp.caseDescription, emp.caseCreatedUser, emp.caseReportedBy, usrList.userTelephone, emp.caseType)}>
                            <td></td>
                            <td> {emp.caseId}</td>
                            <td>{emp.caseName}</td>
                            <td>{emp.caseDescription}</td>
                            <td>{emp.caseCreatedUser}</td>
                            <td>{emp.caseReportedBy}</td>
                            <td>
                                {usrList.map(usr =>
                                    <td>{usr.userTelephone}</td>
                                )}</td>
                            <td>{emp.caseType}</td>
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

    // Returns the HTML table to the render() method.  
    renderModalTable(empList, usrList, x) {
        return (
            <table className='table' id="caseTable2">
                <thead>
                    <tr>
                        <th></th>
                        <th>Case Id</th>
                        <th>Case Name</th>
                        <th>Case Description </th>
                        <th>Created by </th>
                        <th>Reported by </th>
                        <th>Telephone</th>
                        <th>Case Type</th>
                    </tr>
                </thead>
                <tbody>

                    <tr key={this.state.x}>
                        <td></td>
                        <td> {this.state.x}</td>
                        <td>{this.state.xcaseName}</td>
                        <td>{this.state.xcaseDescription}</td>
                        <td>{this.state.xcaseCreatedUser}</td>
                        <td>{this.state.xcaseReportedBy}</td>
                        <td>{this.state.xuserTelephone}</td>
                        <td>{this.state.xcaseType}</td>
                    </tr>

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


            <div>
                <button onClick={this.openModal}>Open Modal</button>
                <Modal
                    isOpen={this.state.modalIsOpen}
                    onAfterOpen={this.afterOpenModal}
                    onRequestClose={this.closeModal}
                    style={customStyles}
                    contentLabel="Example Modal"
                >

                    <h2 ref={subtitle => this.subtitle = subtitle}>{this.state.xcaseName}</h2>
                    

                    <div>{this.state.x.caseName}</div>

                    <div>Id for this row is {this.state.x}, do you want to edit? <br />
                        <a className="action" onClick={(x) => this.handleEdit(this.state.x)}>Edit</a> <br />
                        {this.renderModalTable(this.state.empList, this.state.usrList, this.state.x)}
                    </div>
                    <button onClick={this.closeModal}>close</button>
                </Modal>
            </div>

        </div>);

    }
}



export class CaseData {
    caseId = 0;
    caseName = "";
    caseDescription
    caseCreatedUser
    caseReportedBy
    caseType
}
export class UsersData {
    userLoginName = "";
    userTelephone = "";
}