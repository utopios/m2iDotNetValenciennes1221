import FormTodo from '../../components/FormTodoComponent/FormTodo';
import Notification from '../../components/NotificationComponent/Notification';
import Todo from '../../components/TodoComponent/Todo';
import React, { PureComponent } from 'react';

class ListTodoView extends PureComponent {
    constructor(props) {
        super(props)
        this.state = {
            todos: []
        }
    }

    addTodo = (text) => {
        //... => opérateur spread/rest qui permet de recuperer la totalité des éléments du tableau
        let tmpTodos = [...this.state.todos]
        let newTodo = {
            id: (this.state.todos[this.state.todos.length - 1] != undefined) ? (this.state.todos[this.state.todos.length - 1].id + 1) : 1,
            status: 'undone',
            content: text
        }
        tmpTodos.push(newTodo)
        this.setState({
            todos: tmpTodos
        })
    }

    deleteTodo = (id) => {
        let tmpTodos = []
        for (let todo of this.state.todos) {            
            if (todo.id != id) {
                tmpTodos.push(todo)
            }
        }
        this.setState({
            todos: tmpTodos
        })
    }

    changeStatus = (id, newStatus) => {
        //console.log("Dans TodolistView id: "+id+" new Status : " +newStatus);
        let tmpTodos = []
        for(let todo of this.state.todos) {            
            if(todo.id == id){
                todo.status = newStatus
            }
            tmpTodos.push(todo)
        }
        this.setState({
            todos : tmpTodos
        })
    }

    editTodo = (id, newContent) => {
        let tmpTodos = []
        for(let todo of this.state.todos) {            
            if(todo.id == id){
                todo.content = newContent
            }
            tmpTodos.push(todo)
        }
        this.setState({
            todos : tmpTodos
        })
    }


    render() {
        return (
            <div className='container'>
                <h1>React toDo List</h1>
                <FormTodo addTodo={this.addTodo} />
                <Notification numberTask={this.state.todos.length} />
                {this.state.todos.map((todo,index) => {
                    return (
                        <Todo key={index}
                            editTodo={this.editTodo}
                            deleteTodo={this.deleteTodo}
                            changeStatus={this.changeStatus}
                            todo={todo}
                        />
                    )
                })

                }

            </div>
        );
    }
}

export default ListTodoView;