import React from 'react';
import { NavLink } from 'react-router-dom';
import '../style/NavBar.style.css'

const NavBar = () => {
    return (
        <div className='navigation'>
            <ul>
                <NavLink to="/" className={(nav)=> nav.isActive?'lien Active':'lien'}>
                    <li>Home</li>
                </NavLink>
                <NavLink to="/about" className={(nav)=> nav.isActive?'lien Active':'lien'}>
                    <li>About</li>
                </NavLink>
                <NavLink to="/ailleur" className={(nav)=> nav.isActive?'lien Active':'lien'}>
                    <li>Autre</li>
                </NavLink>
            </ul>
        </div>
    );
};

export default NavBar;