import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import { FetchCase } from './components/FetchCase';
import { AddCase } from './components/AddCase';
import { UserLogin } from './components/UserLogin';

export default class App extends Component {
    displayName = App.name
    constructor() {
        super();
        this.state = { loggedInUser: '' };
    }

    OnLogin(username) {
        this.setState({
            loggedInUser: username
        });
        console.log("OnLogin called with username = " + username);
    }

    render() {
        return (
            <Layout>
                <Route exact path='/' component={Home} />
                <Route path='/counter' component={Counter} />
                <Route path='/fetchdata' component={FetchData} />
                <Route path='/fetchcase' component={FetchCase} />
                <Route path='/addcase' component={AddCase} />
                <Route path='/cases/edit/:caseId' component={AddCase} />
                <Route path='/userLogin' component={UserLogin} />
            </Layout>
        );
    }
}
