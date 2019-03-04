import React, { Component } from 'react';
import { RouteComponentProps } from 'react-router';
import { Link, NavLink } from 'react-router-dom';

export class UserLogin extends Component {
    constructor(props) {
        super(props);

        this.state = { title: "", loading: true, userList: [], userData: new UserData, loggedIn: false };



        var userId = this.props.match.params["userId"];

        // This will set state for Edit user  
        if (userId > 0) {
            fetch('api/Users/Details/' + userId)
                .then(response => response.json())
                .then(data => {
                    this.setState({ title: "Edit", loading: false, userData: data });
                });
        }

        // This will set state for Add user  
        else {
            this.state = { title: "Create", loading: false, userList: [], userData: new UserData };
        }

        // This binding is necessary to make "this" work in the callback  
        this.handleSave = this.handleSave.bind(this);
        this.handleCancel = this.handleCancel.bind(this);
    }

    // This will handle the submit form event.  
    handleSave(event) {
        event.preventDefault();
        const data = new FormData(event.target);
        
        fetch('api/Users/Login', {
            method: 'Get',
            body: data

        }).then((response) => response.json())
            .then((responseJson) => {
                this.setState({
                    loggedIn: responseJson
                });
                this.props.history.push("/fetchcase");
            });

    }

    handleCancel(e) {
        e.preventDefault();
        this.props.history.push("/fetchcase");
    }

    renderLoginForm(userList) {
        return (
            <form onSubmit={this.handleSave} >
                <div className="form-group row" >
                    <input type="hidden" name="userId" value={this.state.userData.userID} />
                </div>
                < div className="form-group row" >
                    <label className=" control-label col-md-12" htmlFor="Name">UserName</label>
                    <div className="col-md-4">
                        <input className="form-control" type="text" name="userName" defaultValue={this.state.userData.userName} required />
                    </div>
                </div >
                < div className="form-group row" >
                    <label className=" control-label col-md-12" htmlFor="Email">Email</label>
                    <div className="col-md-4">
                        <input className="form-control" type="text" name="email" defaultValue={this.state.userData.email} required />
                    </div>
                </div >

                <div className="form-group">
                    <button type="submit" className="btn btn-default">Login</button>
                    <button className="btn" onClick={this.handleCancel}>Cancel</button>
                </div >
            </form >
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderLoginForm(this.state.userList);

        return (<div>
            <h1>{this.state.title}</h1>
            <h3>Case</h3>
            <hr />
            {contents}
        </div>);
    }
}

export class UserData {
    userID = 0;
    userName = "";
    groupName = "";
    email = "";
}  