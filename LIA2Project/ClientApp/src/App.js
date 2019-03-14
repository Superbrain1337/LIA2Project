import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchCase } from './components/FetchCase';
import { AddCase } from './components/AddCase';
import { UserLogin } from './components/UserLogin';

export default class App extends Component {
    displayName = App.name

    render() {
        return (
            <Layout>
                <Route exact path='/' component={Home} />
                <Route path='/fetchcase' component={FetchCase} />
                <Route path='/addcase' component={AddCase} />
                <Route path='/cases/edit/:caseId' component={AddCase} />
                <Route path='/userlogin' component={UserLogin} />
            </Layout>
        );
    }
}
