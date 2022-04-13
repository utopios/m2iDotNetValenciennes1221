import React from 'react';
import './formation-card.style.css';

const FormationCard = (cours, index) => {
    console.log(index + " : " +cours.name);
    return (
        <div className='formation-card'>
            <h1>Component Card work...!</h1>
        </div>
    );
};

export default FormationCard;