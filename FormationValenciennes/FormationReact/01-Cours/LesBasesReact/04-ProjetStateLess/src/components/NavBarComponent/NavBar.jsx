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
import FormationList from '../../views/FormationList/FormationList';
import './navbar.style.css';
import Form from '../../views/FormComponent/Form';



const NavBar = ({cart, updateCart}) => {
    return (
        <div >

            <BrowserRouter >
                <div id='navbar'>
                    <button className='bouton'>
                        <Link to="/">Home</Link>
                    </button>
                    <button className='bouton'>
                        <Link to="/list">List</Link>
                    </button>
                    <button className='bouton'>
                        <Link to="/form">Form</Link>
                    </button>
                    <button className='bouton'>
                        <Link to="about">About</Link>
                    </button>
                </div>
                <Routes>
                    <Route path="/" element={<Home />} />
                    <Route path="/list" element={<FormationList cart={cart} updateCart={updateCart}/>} />
                    <Route path="/form" element={<Form/>} />
                    <Route path="/about" element={<About />} />
                    <Route path="/*" element={<Home />} />
                </Routes>
            </BrowserRouter >

            <div className="container">
                <Outlet />
            </div>

        </div >
    );
};

export default NavBar;