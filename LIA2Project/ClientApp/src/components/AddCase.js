﻿import React, { Component } from 'react';
import { RouteComponentProps } from 'react-router';
import { Link, NavLink } from 'react-router-dom';
import { CaseData } from './FetchCase';
import { UserData } from './UserLogin';
import { DeviceData } from './FetchDevice';



export class AddCase extends Component {
    constructor(props) {
        super(props);

        this.state = { title: "", loading: true, caseList: [], caseData: new CaseData, userData: new UserData, deviceData: new DeviceData, value: 'Allmänt' };

        fetch('api/Cases/Index')
            .then(response => response.json())
            .then(data => {
                this.setState({ caseList: data });
            });
        fetch('api/Devices/Index')
            .then(response => response.json())
            .then(data => {
                this.setState({ devList: data, loading: false });
            });

        var caseId = this.props.match.params["caseId"];
        var userId = this.props.match.params["userId"];

        console.log("Case id: "+ caseId + " User id: " + userId);

        // This will set state for Edit cases  
        if (caseId > 0) {
            fetch('api/Cases/Details/' + caseId)
                .then(response => response.json())
                .then(data => {
                    console.log("caseId > 0 data: " + data);
                    this.setState({ title: "Edit", loading: false, caseData: data });
                });
            console.log("caseData: " + this.state.caseData);
        }

        if (userId > 0) {
            fetch('api/Users/Details/' + userId)
                .then(response => response.json())
                .then(data => {
                    this.setState({ userData: data });
                });
        }

        // This will set state for Add case  
        else {
            this.state = { title: "Create", loading: false, caseList: [], userList: [], caseData: new CaseData, userData: new UserData, deviceData: new DeviceData };
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


        // PUT request for Edit case.  
        if (this.state.caseData.caseId) {
            fetch('api/Cases/Edit', {
                method: 'PUT',
                body: data

            }).then((response) => response.json())
                .then((responseJson) => {
                    this.props.history.push("/fetchcase");
                });
        }

        // POST request for Add case.  
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
                    <input type="hidden" name="caseId" value={this.state.caseData.caseId} />
                </div>
                <div className="form-group row " >
                    <label className=" control-label col-md-12 " htmlFor="Name">Subject</label>
                    <div className="col-md-4 ">
                        <input className="form-control" type="text" name="caseName" defaultValue={this.state.caseData.caseName} required />
                    </div>
                </div >
                <div className="form-group row " >
                    <label className=" control-label col-md-12 " htmlFor="caseDescription">Description</label>
                    <div className="col-lg-4 ">
                        <input className="form-control input-lg" type="text" name="caseDescription" defaultValue={this.state.caseData.caseDescription} required />
                    </div>
                </div >
                <div className="form-group row " >
                    <label className=" control-label col-md-4 " htmlFor="caseType">
                        Case Type:
                            <select value={this.state.value} onChange="this.handleChange" name="caseType" className="form-control input-lg" defaultValue={this.state.caseData.caseType} required>
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
                    <label className=" control-label col-md-4 " htmlFor="casePriority">
                        Priority:
                            <select value={this.state.value} onChange="this.handleChange" name="casePriority" className="form-control input-lg" defaultValue={0} required>
                            <option value="2">Akut</option>
                            <option value="1">Hög</option>
                            <option value="0">Normal</option>
                            <option value="-1">Låg</option>
                            <option value="-2">Ingen</option>
                        </select>
                    </label>
                </div >
                < div className="form-group row" >
                    <label className=" control-label col-md-12" htmlFor="caseNotes">Case Notes</label>
                    <div className="col-md-4">
                        <input className="form-control" type="text" name="caseNotes" defaultValue={this.state.caseData.caseNotes} required />
                    </div>
                </div >
                < div className="form-group row" >
                    <label className=" control-label col-md-12" htmlFor="userTelephone">Telephone *Not Working*</label>
                    <div className="col-md-4">
                        <input className="form-control" type="text" name="caseNotes" required />
                    </div>
                </div >
                < div className="form-group row" >
                    <label className=" control-label col-md-12" htmlFor="caseDeviceGroup">Computer name</label>
                    <div className="col-md-4">
                        <input className="form-control" type="text" name="caseDeviceGroup" defaultValue={this.state.deviceData.CaseDeviceGroup} />
                    </div>
                </div >
                <div className="form-group row ">
                    <label className=" control-label col-md-4 " htmlFor="caseStatus">
                        Case Status:
                            <select value={this.state.value} onChange="this.handleChange" name="caseStatus" className="form-control input-lg" defaultValue={this.state.caseData.caseStatus} disabled="disabled">
                            <option value="0">Nytt</option>
                            <option value="1">Mottaget</option>
                            <option value="2">Tilldelat</option>
                            <option value="3">Arbetar</option>
                            <option value="4">Testar</option>
                            <option value="5">Väntar</option>
                            <option value="6">Pausat</option>
                            <option value="7">Uppskjutet</option>
                            <option value="8">Avbrutet</option>
                            <option value="9">Klart</option>
                            <option value="10">Stoppat</option>
                            <option value="11">Godkänt</option>
                            <option value="12">Ej Godkänt</option>
                        </select>
                    </label>
                </div > 
                <div className="form-group row " >
                   
                    <div className="col-lg-4 ">
                        <input className="form-control" type="hidden" name="caseCreatedUser" defaultValue={sessionStorage.getItem("userName")} />
                    </div>
                </div >
                <div className="form-group row " >
                    
                    <div className="col-lg-4 ">
                        <input className="form-control" type="hidden" name="caseReportedBy" defaultValue={sessionStorage.getItem("userName")} />
                    </div>
                </div>
                

                <div className="form-group">
                    <button type="submit" className="btn btn-success">Report Case</button>
                    <button className="btn" onClick={this.handleCancel}>Cancel</button>
                </div >
            </form>
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