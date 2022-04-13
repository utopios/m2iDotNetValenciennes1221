import React from 'react';
import CareScale from '../CareScaleComponent/CareScale';
import './formation-card.style.css';

const FormationCard = (cours, index) => {
    //console.log(index + " : " + cours.name);
    return (
        <div className='card' key={index}>
            <div className="card-title">
                {cours.name}
            </div>
            <div>
                <img className='img' src={cours.logo} alt="Formation-Logo" />
            </div>
            <div className="category">
                <span>Catégory : </span>
                {cours.category}
            </div>
            <div className="difficulty">
                <span className='diff-label'>Difficulté : </span>
                <CareScale scaleValue={cours.difficulte} className="stars"/>
               
            </div>
            <div className="price">
                <span>Price :</span> <b>{cours.price}€</b>
            </div>
        </div>
    );
};

export default FormationCard;