import React from 'react';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faHome } from "@fortawesome/free-solid-svg-icons";
import './Home.css';

const Home = () => {
    return (
        <div>
            <h1>Home Component</h1>
            {/* <img src="./img/logo192.png" alt="Logo-react" /> */}
            <FontAwesomeIcon icon={faHome} style={{ color: 'rgb(40, 44, 52)',fontSize:'100px' }} />
        </div>
    );
};

export default Home;