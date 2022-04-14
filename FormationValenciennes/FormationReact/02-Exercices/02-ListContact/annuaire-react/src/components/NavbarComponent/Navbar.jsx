import React from 'react';
import {
    BrowserRouter,
    Routes,
    Route,
    Outlet,
    Link
} from 'react-router-dom';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faHome, faAddressCard, faFolderPlus } from "@fortawesome/free-solid-svg-icons";
import AddPerson from '../../views/AddPersonComponent/AddPerson';
import Home from '../../views/HomeComponent/Home';
import PersonListView from '../../views/PersonListView/PersonListView';
import './Navbar.css';

const Navbar = ({ PersonList, updatePersonList }) => {
    return (
        <div>
            <BrowserRouter>
                <div id="navbar">
                    {/* <button className='bouton'>
                        <Link to="/">Home</Link>
                    </button>
                    <button className='bouton'>
                        <Link to="/list">List</Link>
                    </button>
                    <button className='bouton'>
                        <Link to="/add">Add</Link>
                    </button> */}
                    <Link to="/">
                        <FontAwesomeIcon icon={faHome} className="iconMenu" />
                    </Link>
                    <Link to="/list">
                        <FontAwesomeIcon icon={faAddressCard} className="iconMenu" />
                    </Link>
                    <Link to="/add">
                        <FontAwesomeIcon icon={faFolderPlus} className="iconMenu" />
                    </Link>
                    <hr />
                </div>

                <Routes>
                    <Route path="/" element={<Home />} />
                    <Route path="/list" element={<PersonListView PersonList={PersonList} updatePersonList={updatePersonList} />} />
                    <Route path="/add" element={<AddPerson PersonList={PersonList} updatePersonList={updatePersonList} />} />
                </Routes>
            </BrowserRouter>

            <div className="container">
                <Outlet />
            </div>
        </div>
    );
};

export default Navbar;