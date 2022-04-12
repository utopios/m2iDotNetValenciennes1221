import React from 'react';
import {
    BrowserRouter,
    Routes,
    Route,
    Outlet,
    Link
} from 'react-router-dom';
import Home from '../../views/HomeComponent/Home';
import About from '../../views/AboutComponent/About';
import './navbar.style.css';



const NavBar = () => {
    return (
        <div >

            <BrowserRouter >
                <div className='navbar'>
                    <button className='bouton'>
                        <Link to="/">Home</Link>
                    </button>
                    <button className='bouton'>
                        <Link to="about">About</Link>
                    </button>
                </div>
                <Routes>
                    <Route path="/" element={<Home />} />
                    <Route path="/about" element={<About />} />
                    <Route path="/*" element={<Home />} />
                </Routes>
            </BrowserRouter >


            <Outlet />
        </div >
    );
};

export default NavBar;