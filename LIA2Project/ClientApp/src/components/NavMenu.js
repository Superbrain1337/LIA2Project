import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import { Glyphicon, Nav, Navbar, NavItem } from 'react-bootstrap';
import { LinkContainer } from 'react-router-bootstrap';
import './NavMenu.css';

export class NavMenu extends Component {
    displayName = NavMenu.name
    
    

    checkText() {
        if (sessionStorage.getItem('loggedIn') === 'false') {
            return 'Logout User';
        }
        else {
            return 'Login User';
        }
    }

    render() {
        console.log('NavMenu Render');
        let theText = this.checkText();

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
                        <LinkContainer to={'/fetchcase'}>
                            <NavItem>
                                <Glyphicon glyph='th-list' /> Fetch case
                            </NavItem>
                        </LinkContainer>
                        <LinkContainer to={'/fetchdevice'}>
                            <NavItem>
                                <Glyphicon glyph='th-list' /> Fetch device
                            </NavItem>
                        </LinkContainer>
                        <LinkContainer to={'/userLogin'}>
                            <NavItem>
                                <Glyphicon glyph='th-list' /> {theText}
                            </NavItem>
                        </LinkContainer>
                    </Nav>
                </Navbar.Collapse>
            </Navbar>
        );
    }
}
