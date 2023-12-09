import React from 'react';
import { Container, Navbar, NavbarBrand, Nav } from 'react-bootstrap';
import { NavLink } from 'react-router-dom';

const Header = () => {
  return (
    <>
      <Navbar bg='primary' variant='dark'>
        <Container>
          <NavbarBrand>
            <NavLink className="nav-link" to="/">FS-2310-13 Github Finder App</NavLink>
          </NavbarBrand>
          <Nav className="ms-auto">
            <NavLink className="nav-link" to="/">Home</NavLink>
            <NavLink className="nav-link" to="/search">Search</NavLink>
          </Nav>
        </Container>
      </Navbar>
    </>
  )
}

export default Header;  