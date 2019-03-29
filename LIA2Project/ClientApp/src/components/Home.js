import React, { Component } from 'react';


export class Home extends Component {
    displayName = Home.name


    renderRecentCases() {

    }

    render() {
        return (

            <div>
                <h1>Welcome to DuoSTATION servicedesk! </h1>
                <p>Here you can register new cases an search in our knowledgebase.</p>
                <p> To logon to this service, you must be a customer and been assigned an account and password. </p>
                <hr />
                <h2>My most recent cases</h2>
                <p>You must log in to see the cases</p>
                <hr />
                <h2>Information</h2>
            </div>
            

        );
    }
}
