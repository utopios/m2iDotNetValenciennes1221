import React from 'react';
import './formation-card.style.css';

const FormationCard = (cours, index) => {
    console.log(index + " : " + cours.name);
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
                <span>Difficulté : </span>
                {cours.difficulte}
            </div>
            <div className="price">
                Price : <b>{cours.price}€</b>
            </div>
        </div>
    );
};

export default FormationCard;