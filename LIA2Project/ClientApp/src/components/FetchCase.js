import { RouteComponentProps } from 'react-router';
import { Link, NavLink } from 'react-router-dom';
import React, { Component } from 'react';
import Modal from 'react-modal';
import { UserData } from './UserLogin';
import './Table.css';

const customStyles = {
    content: {
        top: '50%',
        left: '50%',
        right: '60%',
        bottom: 'auto',
        marginRight: '-50%',
        transform: 'translate(-50%, -50%)'
    }
};



export class FetchCase extends Component {
    constructor(props) {
        super(props);
        this.state = { caseList: [], devList: [], loading: true, modalIsOpen: false, x: 0};

        fetch('api/Cases/Index')
            .then(response => response.json())
            .then(data => {
                this.setState({ caseList: data, loading: false });
            });
        fetch('api/Devices/Index')
            .then(response => response.json())
            .then(data => {
                this.setState({ devList: data, loading: false });
            });
        // This binding is necessary to make "this" work in the callback  
        this.handleDelete = this.handleDelete.bind(this);
        this.handleEdit = this.handleEdit.bind(this);
        this.openModal = this.openModal.bind(this);
        this.afterOpenModal = this.afterOpenModal.bind(this);
        this.closeModal = this.closeModal.bind(this);
    }

    
    componentDidMount() {
        if (sessionStorage.getItem('loggedIn') !== 'true') {
            this.props.history.push("/userlogin");
        }
    }

    openModal(input, input2, input3, input4, input5, input6, input7, input8, input9, input10) {
        this.setState({ modalIsOpen: true, x: input, xcaseName: input2, xcaseDescription: input3, xcaseCreatedUser: input4, xcaseReportedBy: input5, xcaseNotes: input6, xcaseType: input7, xcaseStatus: input8, xcaseCalcTime: input9, xcasePriority: input10 });
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
                        <th>Computer Name</th>
                    </tr>
                </thead>
                <tbody>
                    {caseList.map(emp =>
                        (<tr key={emp.caseId} onClick={() => this.openModal(emp.caseId, emp.caseName, emp.caseDescription, emp.caseCreatedUser, emp.caseReportedBy, emp.caseNotes, emp.caseType, emp.caseStatus, emp.caseCalcTime, emp.casePriority)}>
                            <td></td>
                            <td> {emp.caseId}</td>
                            <td>{emp.caseName}</td>
                            <td>{emp.caseDescription}</td>
                            <td>{emp.caseNotes}</td>
                            <td>{emp.caseCreatedUser}</td>
                            <td>{emp.caseReportedBy}</td>
                            <td>{emp.caseType}</td>
                            <td>{emp.caseStatus}</td>
                            <td></td>
                            
                            <td>
                                <a className="action" onClick={(id) => this.handleEdit(emp.caseId)}>Edit</a> |
                                <a className="action" onClick={(id) => this.handleDelete(emp.caseId)}>Delete</a>
                            </td>

                        </tr>))}
                    {devList.map(dev =>
                        (<tr key={dev.caseId}>
                            <td>{dev.caseDeviceName}</td>
                            <td>{dev.caseId}</td>
                        </tr>))}
                </tbody>
            </table>
        );
    }
    renderPrioritySwitch(x) {
        switch (x) {
            case 2:
                return 'Akut';
            case 1:
                return 'Hög';
            case 0:
                return 'Normal';
            case -1:
                return 'Låg';
            case -2:
                return 'Ingen';
            default:
                return 'Normal';
        }
    }
    renderTypeSwitch(x) {
        switch (x) {
            case 0:
                return 'Allmänt';
            case 1:
                return 'Support';
            case 2:
                return 'Inköp';
            case 3:
                return 'Change';
            case 4:
                return 'Problem';
            case 5:
                return 'Incident';
            case 6:
                return 'Service request';
            default:
                return 'Allmänt';
        }
    }
    renderStatusSwitch(x) {
        switch (x) {
            case 0:
                return 'Nytt';
            case 1:
                return 'Mottaget';
            case 2:
                return 'Tilldelat';
            case 3:
                return 'Arbetar';
            case 4:
                return 'Testar';
            case 5:
                return 'Väntar';
            case 6:
                return 'Pausat';
            case 7:
                return 'Uppskjutet';
            case 8:
                return 'Avbrutet';
            case 9:
                return 'Klart';
            case 10:
                return 'Stoppat';
            case 11:
                return 'Godkänt';
            case 12:
                return 'Ej godkänt';
            default:
                return 'Nytt';
        }
    }
    // Returns the HTML table to the render() method.  
    renderModalTable(empList, usrList, x) {
        return (
            <table className='table' id="caseTable2" >
                <thead>
                    <tr className="notfirst">
                        <th></th>
                        <th>Case Id</th>
                        <th>Case Name</th>
                        <th>Case Description </th>
                        <th>Case Notes </th>
                        <th>Created by </th>
                        <th>Reported by </th>
                        <th>Case Type</th>
                        <th>Status</th>
                        <th>Estimated Time</th>
                        <th>Priority</th>
                    </tr>
                </thead>
                <tbody>

                    <tr key={this.state.x}>
                        <td></td>
                        <td> {this.state.x}</td>
                        <td>{this.state.xcaseName}</td>
                        <td>{this.state.xcaseDescription}</td>
                        <td>{this.state.xcaseNotes}</td>
                        <td>{this.state.xcaseCreatedUser}</td>
                        <td>{this.state.xcaseReportedBy}</td>
                        <td>{this.renderTypeSwitch(this.state.xcaseType)}</td>
                        <td>{this.renderStatusSwitch(this.state.xcaseStatus)}</td>
                        <td>{this.state.xcaseCalcTime} Minute(s)</td>
                        <td>{this.renderPrioritySwitch(this.state.xcasePriority)}
                            
                        </td>
                        
                    </tr>

                </tbody>
            </table>
        );
    }

    /*Detta ska kunnas ses i vår modal
 
Number *
Status *
Reported 
Estimated to be finished *
Service ?

Case *
Priority *
Reported by *
Handler
Group


 */

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderCaseTable(this.state.caseList, this.state.devList);

        let username = sessionStorage.getItem('userName');

        return (<div>
            <h1>Case Data Å Ä Ö</h1>
            <p>This component demonstrates fetching Case data from the server.</p>
            <p>The logged in user is --- {username} ---</p>
            <p>
                <Link to="/addcase">Create New</Link>
            </p>
            {contents}


            <div>
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
    caseNotes
    caseStatus
    caseCalcTime
    casePriority
}
export class UsersData {
    userLoginName = "";
    userTelephone = "";
}