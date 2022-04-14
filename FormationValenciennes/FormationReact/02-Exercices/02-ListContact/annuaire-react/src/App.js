import { useState, useEffect } from 'react';
//import { ListPerson } from './datas/ListPerson';
import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';
import Navbar from './components/NavbarComponent/Navbar';

function App() {
  const savedList = localStorage.getItem('List');
  //const [PersonList , updatePersonList] = useState(ListPerson);
  const [PersonList, updatePersonList] = useState(savedList ? JSON.parse(savedList) : []);
  useEffect(() => {
    localStorage.setItem('List',JSON.stringify(PersonList))
  }, [PersonList])
  return (
    <div className="App">
      <Navbar PersonList={PersonList} updatePersonList={updatePersonList} />
    </div>
  );
}

export default App;
