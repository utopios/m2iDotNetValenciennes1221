import React from 'react';
import FormationCard from '../../components/FormationCard/FormationCard';
import { coursList } from '../../datas/CoursList';
import './formation-list.style.css';

const FormationList = () => {
    return (
        <div className='formation-list'>
            <h2>Nos Formation</h2>
            <div className="search">
                <div className="row">
                    <div className="col-8">
                        {/* Affichage du composant trie */}
                    </div>
                    <div className="col-4">
                        {/* Affichage du component Cart */}
                    </div>
                </div>
            </div>
            <div className="card-container">
                {coursList.map((cours,index)=>
                <div key={index}>
                    {/*Affichage du composant Card*/}
                    <FormationCard 
                        name={cours.name}
                        logo={cours.logo}
                        category={cours.category}
                        difficulte={cours.difficulte}
                        price={cours.price}
                        index={index}
                    />
                </div>
                )}
            </div>
        </div>
    );
};

export default FormationList;