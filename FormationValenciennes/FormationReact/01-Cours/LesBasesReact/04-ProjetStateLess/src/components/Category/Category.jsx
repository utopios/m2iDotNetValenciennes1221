import React from 'react';
import './category.style.css';

const Category = ({ setActiveCategory, activeCategory, categoryList }) => {
    // console.log("SetActiveCategory : "+setActiveCategory);
    // console.log("activeCategory : "+activeCategory);
    // console.log("CategoryList : "+categoryList);
    return (
        <div className='category'>
            <select
                name="category"
                className='form-select categories'
                value={activeCategory}
                onChange={(e) => setActiveCategory(e.target.value)}
            >
                <option value="">---</option>
                {
                    categoryList.map(
                        (cat) => (
                            <option key={cat} value={cat}>{cat}</option>
                        )
                    )
                }

            </select>
            <button
                className='btn btn-secondary'
                onClick={() => setActiveCategory('')}
            >Reset</button>

        </div>
    );
};

export default Category;