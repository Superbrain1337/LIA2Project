import React, { Component } from 'react';
import { Route, Redirect } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import { FetchCase } from './components/FetchCase';
import { AddCase } from './components/AddCase';

export default class App extends Component {
  displayName = App.name

  render() {
    return (
        <Layout>
            <Route exact path='/' component={Home} />
            <Redirect from="/" to="Home" />
            <Route path='/counter' component={Counter} />
            <Route path='/fetchdata' component={FetchData} />
            <Route path='/fetchcase' component={FetchCase} />
            <Route path='/addcase' component={AddCase} />
            <Route path='/cases/edit/:empid' component={AddCase} />
      </Layout>
    );
  }
}
