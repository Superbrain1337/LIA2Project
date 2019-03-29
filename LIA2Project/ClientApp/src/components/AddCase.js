import React, { Component } from 'react';
import { RouteComponentProps } from 'react-router';
import { Link, NavLink } from 'react-router-dom';
import { CaseData } from './FetchCase';
import { UsersData } from './FetchCase';



export class AddCase extends Component {
    constructor(props) {
        super(props);



        this.state = { title: "", loading: true, caseList: [], userList: [], empData: new CaseData, usrData: new UsersData, value: 'Allmänt' };

        fetch('api/Cases/Index')
            .then(response => response.json())
            .then(data => {
                this.setState({ caseList: data });
            });
        fetch('api/Users/Index')
            .then(response => response.json())
            .then(data => {
                this.setState({ usrList: data, loading: false });
            });

        var empid = this.props.match.params["empid"];

        // This will set state for Edit employee  
        if (empid > 0) {
            fetch('api/Cases/Details/' + empid)
                .then(response => response.json())
                .then(data => {
                    this.setState({ title: "Edit", loading: false, empData: data });
                });
        }

        // This will set state for Add employee  
        else {
            this.state = { title: "Create", loading: false, caseList: [], userList: [], empData: new CaseData, usrData: new UsersData };
        }

        // This binding is necessary to make "this" work in the callback  
        this.handleChange = this.handleChange.bind(this);
        this.handleSave = this.handleSave.bind(this);
        this.handleCancel = this.handleCancel.bind(this);
    }



    handleChange(event) {
        this.setState({ value: event.target.value });
    }
    // This will handle the submit form event.  
    handleSave(event) {
        event.preventDefault();
        const data = new FormData(event.target);

        // PUT request for Edit employee.  
        if (this.state.empData.caseId) {
            fetch('api/Cases/Edit', {
                method: 'PUT',
                body: data

            }).then((response) => response.json())
                .then((responseJson) => {
                    this.props.history.push("/fetchcase");
                });
        }

        // POST request for Add employee.  
        else {
            fetch('api/Cases/Create', {
                method: 'POST',
                body: data

            }).then((response) => response.json())
                .then((responseJson) => {
                    this.props.history.push("/fetchcase");
                });
        }
    }

    // This will handle Cancel button click event.  
    handleCancel(e) {
        e.preventDefault();
        this.props.history.push("/fetchcase");
    }

    // Returns the HTML Form to the render() method.  
    renderCreateForm(caseList, userList) {
        return (
            <form onSubmit={this.handleSave} >
                <div className="form-group row " >
                    <input type="hidden" name="caseId" value={this.state.empData.caseId} />
                </div>
                <div className="form-group row " >
                    <label className=" control-label col-md-12 " htmlFor="Name">Case Name</label>
                    <div className="col-md-4 ">
                        <input className="form-control" type="text" name="caseName" defaultValue={this.state.empData.caseName} required />
                    </div>
                </div >
                <div className="form-group row " >
                    <label className=" control-label col-md-12 " htmlFor="caseDescription">Description</label>
                    <div className="col-lg-4 ">
                        <input className="form-control input-lg" type="text" name="caseDescription" defaultValue={this.state.empData.caseDescription} required />
                    </div>
                </div >
                <div className="form-group row " >
                    <label className=" control-label col-md-12 " htmlFor="userTelephone">Telephone</label>
                    <div className="col-lg-4 ">
                        <input className="form-control input-lg" onChange="this.handleChange" type="text" name="userTelephone" defaultValue={this.state.usrData.userTelephone} required />
                    </div>
                </div >
                <div className="form-group row " >
                    <label className=" control-label col-md-4 " htmlFor="caseType">
                            Case Type:
                            <select value={this.state.value} onChange="this.handleChange" name="caseType" className="form-control input-lg" defaultValue={this.state.empData.caseType} required>
                                <option value="0">Allmänt</option>
                                <option value="1">Support</option>
                                <option value="2">Inköp</option>
                                <option value="3">Change</option>
                                <option value="4">Problem</option>
                                <option value="5">Incident</option>
                                <option value="6">Service Request</option>
                            </select>
                    </label>
                </div >
                <div className="form-group row " >
                    <label className=" control-label col-md-12 " htmlFor="caseCreatedUser">Created by</label>
                    <div className="col-lg-4 ">
                        <input className="form-control" type="text" name="caseCreatedUser" defaultValue={this.state.empData.caseCreatedUser} disabled="disabled" />
                    </div>
                </div >
                <div className="form-group row " >
                    <label className=" control-label col-md-12 " htmlFor="caseReportedBy">Reported by</label>
                    <div className="col-lg-4 ">
                        <input className="form-control" type="text" name="caseReportedBy" defaultValue={this.state.empData.caseReportedBy} disabled="disabled" />
                    </div>
                </div >
                <div className="form-group">
                    <button type="submit" className="btn btn-success">Report case</button>
                    <button className="btn" onClick={this.handleCancel}>Cancel</button>
                </div>
            </form >
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderCreateForm(this.state.caseList);

        return (<div>
            <h1>{this.state.title}</h1>
            <h3>Case</h3>
            <hr />
            {contents}

        </div>);
    }
}  