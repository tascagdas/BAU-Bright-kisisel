import './App.css';
import TodoWrapper from './Components/TodoWrapper';
import { v4 as idGenerate } from 'uuid';

let INITIAL_STATE = [
  { id: idGenerate(), desc: "Ayse Nur Aranicak.", isCompleted: false, isEditing: false },
  { id: idGenerate(), desc: "Sinemaya git, Olumlu dunya 2 gelmis", isCompleted: false, isEditing: false },
  { id: idGenerate(), desc: "Okan Bayulgen neden bahsediyor", isCompleted: true, isEditing: false },
  { id: idGenerate(), desc: "Gibi 5. sezonu izlemeye kacak yer bul", completed: false, isEditing: false },
  { id: idGenerate(), desc: "JS konferansini unutma", isCompleted: false, isEditing: false }
];

function App() {


  return (
    <>
      <TodoWrapper tasks={INITIAL_STATE} />
    </>
  );
}

export default App;
