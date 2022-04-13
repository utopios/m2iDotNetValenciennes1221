import React from 'react';
import { useState } from 'react';
import Cart from '../../components/Cart/Cart';
import Category from '../../components/Category/Category';
import FormationCard from '../../components/FormationCard/FormationCard';
import { coursList } from '../../datas/CoursList';
import './formation-list.style.css';

const FormationList = ({ cart, updateCart }) => {
    const [activeCategory, setActiveCategory] = useState('');

    const categoryList = coursList.reduce(
        (acc, elem) =>
            acc.includes(elem.category) ? acc : acc.concat(elem.category),
        []
    )
    //console.log("CategoryListFromFormationList: " + categoryList)

    function AddToCart(name, price) {
        // Rechercher si la formation est deja présente dans mon panier
        const formationAdded = cart.find((cours) => cours.name === name);

        // Vérification Si la formation est deja présente
        if(formationAdded){
            const filtreredCart = cart.filter(
                (cours)=> cours.name !== name
            )
            updateCart([
                ...filtreredCart,
                {name,price, amount: formationAdded.amount + 1} // Update la quantité
            ])
        }
        else{
            updateCart([...cart,{name,price, amount: 1}]) // Sinon ajout de la formation au panier (quantité de 1)
        }
        alert(`La formation ${name} a été ajouté !`)
    }


    return (
        <div className='formation-list'>
            <h2>Nos Formation</h2>
            <div>
                <div className="row">
                    <div className="col-8">
                        <Category
                            categoryList={categoryList}
                            setActiveCategory={setActiveCategory}
                            activeCategory={activeCategory}
                        />
                    </div>
                    <div className="col-2 paddingTop">
                        <Cart cart={cart} updateCart={updateCart} />
                    </div>
                </div>
            </div>
            <div className="card-container">
                {coursList.map((cours, index) =>
                    !activeCategory || activeCategory === cours.category ?
                        <div key={index} onClick={()=>AddToCart(cours.name,cours.price)}> 
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