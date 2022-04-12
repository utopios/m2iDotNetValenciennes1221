import React from 'react';
import './banner.style.css';

const Banner = () => {
    return (
        <div className='banner'>
            <img src="./img/M2ILOGO2.png" alt="LogoM2i" />
            <h2>M2iFormation</h2>
            <span className='description'>Votre formation sur mesure...</span>            
        </div>
    );
};

export default Banner;