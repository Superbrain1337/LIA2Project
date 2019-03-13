﻿import React, { Component } from 'react';
import { Link, NavLink } from 'react-router-dom';
import { Glyphicon, Nav, Navbar, NavItem } from 'react-bootstrap';
import { LinkContainer } from 'react-router-bootstrap';
import './NavMenu.css';

let userName = document.getElementById('react-app');
console.log('userName: ' + userName);

export class NavMenu extends Component {
    displayName = NavMenu.name
    

  render() {
    return (
      <Navbar inverse fixedTop fluid collapseOnSelect>
        <Navbar.Header>
          <Navbar.Brand>
            <Link to={'/'}>LIA2Project</Link>
          </Navbar.Brand>
          <Navbar.Toggle />
        </Navbar.Header>
        <Navbar.Collapse>
          <Nav>
            <LinkContainer to={'/'} exact>
              <NavItem>
                <Glyphicon glyph='home' /> Home
              </NavItem>
            </LinkContainer>
            <LinkContainer to={'/counter'}>
              <NavItem>
                <Glyphicon glyph='education' /> Counter
              </NavItem>
            </LinkContainer>
            <LinkContainer to={'/fetchdata'}>
              <NavItem>
                <Glyphicon glyph='th-list' /> Fetch data
              </NavItem>
            </LinkContainer>
            <LinkContainer to={'/fetchcase'}>
              <NavItem>
                <Glyphicon glyph='th-list' /> Fetch case
              </NavItem>
                    </LinkContainer>
                    <NavItem>
                        <div className="login">
                            Login: {userName}
                        </div>
                    </NavItem>
                    

          </Nav>
        </Navbar.Collapse>
      </Navbar>
    );
  }
}
