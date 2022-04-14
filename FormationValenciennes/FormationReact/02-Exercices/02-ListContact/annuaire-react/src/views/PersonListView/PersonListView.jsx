import React from 'react';
import PersonArray from '../../components/PersonArrayComponent/PersonArray';
import './PersonListView.css';

const PersonListView = ({ PersonList, updatePersonList }) => {
    return (
        <div className='container'>
            <h1>Liste des contacts</h1>
            <PersonArray PersonList={PersonList}/>
        </div>
    );
};

export default PersonListView;