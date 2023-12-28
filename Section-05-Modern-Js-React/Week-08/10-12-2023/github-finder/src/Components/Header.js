import React from 'react'
import { Container, Nav, Navbar, NavbarBrand } from 'react-bootstrap'
import { Link, NavLink } from 'react-router-dom'

const Header = () => {
  return (
    <>
      <Navbar bg='primary' variant='dark'>
        <Container>
          <NavbarBrand>
            <NavLink className={"nav-link"} to="/">FS-2310-13 Github User Finder App</NavLink>
          </NavbarBrand>
          <Nav className='ms-auto'>
            <NavLink className="nav-link" to="/">Home</NavLink>
            <NavLink className="nav-link" to="/Search">Search</NavLink>
            <Link className='nav-link' to="/Search">Search a element</Link>
          </Nav>
        </Container>
      </Navbar>
    </>
  )
}

export default Header