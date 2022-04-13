import React from 'react';
import { useState } from 'react';
import Category from '../../components/Category/Category';
import FormationCard from '../../components/FormationCard/FormationCard';
import { coursList } from '../../datas/CoursList';
import './formation-list.style.css';

const FormationList = () => {
    const [activeCategory, setActiveCategory] = useState('');

    const categoryList = coursList.reduce(
        (acc, elem) =>
            acc.includes(elem.category) ? acc : acc.concat(elem.category),
        []
    )
    //console.log("CategoryListFromFormationList: " + categoryList)



    return (
        <div className='formation-list'>
            <h2>Nos Formation</h2>
            <div className="search">
                <div className="row">
                    <div className="col-8">
                        {/* Affichage du composant trie */}
                        <Category
                            categoryList={categoryList}
                            setActiveCategory={setActiveCategory}
                            activeCategory={activeCategory}
                        />
                    </div>
                    <div className="col-4">
                        {/* Affichage du component Cart */}
                    </div>
                </div>
            </div>
            <div className="card-container">
                {coursList.map((cours, index) =>
                    !activeCategory || activeCategory === cours.category ?
                        <div key={index}>
                            <FormationCard
                                name={cours.name}
                                logo={cours.logo}
                                category={cours.category}
                                difficulte={cours.difficulte}
                                price={cours.price}
                                index={index}
                            />
                        </div>
                        :
                        null
                )}
            </div>
        </div>
    );
};

export default FormationList;