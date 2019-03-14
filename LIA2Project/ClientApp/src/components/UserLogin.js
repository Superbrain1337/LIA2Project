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
    handleSave(id, username, password, email) {
        //event.preventDefault();
        //const data = new FormData(event.target);

        fetch('api/Users/Login?id=' + id + '&userName=' + username + '&password=' + password + '&email=' + email)
            .then((response) => response.json())
            .then((responseJson) => {
                if (responseJson === true) {
                    let U = new UserData({ userID: id, userName: username, email: email });
                    console.log("User " + U.userName + " is logging in");
                    this.setState({
                        UserData: U,
                        loggedIn: true
                    });
                    console.log("User " + U.userName + " logged in succesfully");
                    sessionStorage.setItem("loggedIn", true);
                    sessionStorage.setItem("userName", username);
                    sessionStorage.setItem("userEmail", email);
                }
                //this.props.history.push("/fetchcase");
            });

    }

    handleCancel(e) {
        e.preventDefault();
        this.props.history.push("/fetchcase");
    }

    renderLoginForm(userList) {
        console.log("renderLoginForm with userlist = " + userList);

        return (
            <form>
                <div className="form-group row" >
                    <input type="hidden" name="userId" id="userId" value={this.state.userData.userID} />
                </div>
                < div className="form-group row" >
                    <label className=" control-label col-md-12" htmlFor="Name">UserName</label>
                    <div className="col-md-4">
                        <input className="form-control" type="text" name="userName" id="userName" defaultValue={this.state.userData.userName} required />
                    </div>
                </div >
                < div className="form-group row" >
                    <label className=" control-label col-md-12" htmlFor="Password">Password</label>
                    <div className="col-md-4">
                        <input className="form-control" type="password" name="password" id="password" defaultValue={this.state.userData.userName} required />
                    </div>
                </div >
                < div className="form-group row" >
                    <label className=" control-label col-md-12" htmlFor="Email">Email</label>
                    <div className="col-md-4">
                        <input className="form-control" type="text" name="email" id="email" defaultValue={this.state.userData.email} required />
                    </div>
                </div >

                <div className="form-group">
                    <button type="submit" className="btn btn-default" onClick={() => this.handleSave(document.getElementById("userId").value, document.getElementById("userName").value, document.getElementById("password").value, document.getElementById("email").value)}>Login</button>
                    <button className="btn" onClick={this.handleCancel}>Cancel</button>
                </div >
            </form >
        );


    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderLoginForm(this.state.userList);

        if (sessionStorage.getItem('loggedIn') === true) {
            this.history.push("/fetchcase");
        }
        else {
            return (<div>
                <h1>{this.state.title}</h1>
                <h3>User</h3>
                <hr />
                {contents}
            </div>);
        }

    }
}

export class UserData {
    userID = 5;
    userName = "";
    password = "";
    groupName = "";
    email = "";
}  