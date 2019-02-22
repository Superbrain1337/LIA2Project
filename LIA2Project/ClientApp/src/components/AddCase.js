import React, { Component } from 'react';
import { RouteComponentProps } from 'react-router';
import { Link, NavLink } from 'react-router-dom';
import { CaseData } from './FetchCase';

export class AddCase extends Component {
    constructor(props) {
        super(props);

        this.state = { title: "", loading: true, caseList: [], empData: new CaseData };

        fetch('api/Cases/Index')
            .then(response => response.json())
            .then(data => {
                this.setState({ caseList: data });
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
            this.state = { title: "Create", loading: false, caseList: [], empData: new CaseData };
        }

        // This binding is necessary to make "this" work in the callback  
        this.handleSave = this.handleSave.bind(this);
        this.handleCancel = this.handleCancel.bind(this);
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
    renderCreateForm(caseList) {
        return (
            <form onSubmit={this.handleSave} >
                <div className="form-group row" >
                    <input type="hidden" name="caseId" value={this.state.empData.caseId} />
                </div>
                < div className="form-group row" >
                    <label className=" control-label col-md-12" htmlFor="Name">Case Name</label>
                    <div className="col-md-4">
                        <input className="form-control" type="text" name="caseName" defaultValue={this.state.empData.caseName} required />
                    </div>
                </div >
                <div className="form-group">
                    <button type="submit" className="btn btn-default">Save</button>
                    <button className="btn" onClick={this.handleCancel}>Cancel</button>
                </div >
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