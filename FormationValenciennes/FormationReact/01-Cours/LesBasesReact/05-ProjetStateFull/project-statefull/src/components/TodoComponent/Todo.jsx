import React, { PureComponent } from 'react';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faCheck, faPenToSquare, faTrash } from "@fortawesome/free-solid-svg-icons";

class Todo extends PureComponent {

    constructor(props) {
        super(props)
        this.state = {
            edit: false,
            editTodoContent: undefined
        }
    }

    changeStatus = () => {
        const status = this.props.todo.status === 'done' ? 'undone' : 'done';
        this.props.changeStatus(this.props.todo.id, status);
        this.forceUpdate();
    }

    renderDoneOrUndoneButton = () => {
        console.log(this.props.todo);
        return this.props.todo.status === 'done' ?
            <FontAwesomeIcon
                icon={faCheck}
                style={{ color: 'green', fontSize: '25px' }}
                onClick={this.changeStatus}
            />
            :
            <FontAwesomeIcon
                icon={faCheck}
                style={{ color: 'red', fontSize: '25px' }}
                onClick={this.changeStatus}
            />
        // <button onClick={this.changeStatus} className="btn btn-success m-1">done</button>
        // :
        // <button onClick={this.changeStatus} className="btn btn-danger m-1">undone</button>           
    }


    validEditTodo = (e) => {
        e.preventDefault();
        this.props.editTodo(this.props.todo.id, this.state.editTodoContent);
        this.setState({
            edit: false
        });
    }

    EditTodo = () => {
        return (
            <form onSubmit={this.validEditTodo} className="col-6">
                <input onChange={(e) => {
                    this.setState({
                        editTodoContent: e.target.value
                    })
                }} type="text" className='form-control' defaultValue={this.props.todo.content} />
            </form>
        )
    }

    renderTodo = () => {
        if (!this.state.edit) {
            return this.renderContentTodo();
        }
        else {
            return this.EditTodo();
        }
    }

    renderContentTodo = () => {
        return (
            <div onClick={this.changeStatus} className={(this.props.todo.status === 'done') ? 'btn col-6 text-success' : 'btn col-6 text-danger'}>
                {this.props.todo.content}
            </div>
        )
    }


    render() {
        return (
            <div className='row'>
                <div className="col-9">
                    {this.renderTodo()}
                </div>
                <div className="col-1">
                    {this.renderDoneOrUndoneButton()}
                </div>
                <div className="col-1">
                    {/* <button className='btn btn-warning' onClick={() => {
                        this.setState({
                            edit: true
                        })
                    }}>Edit</button> */}
                    <FontAwesomeIcon
                        icon={faPenToSquare}
                        style={{ color: 'rgb(40, 44, 52)', fontSize: '25px' }}
                        onClick={() => {
                            this.setState({
                                edit: true
                            })
                        }}
                    />
                </div>
                <div className='col-1'>
                    {/* <button className='btn btn-danger' onClick={() => {
                        this.props.deleteTodo(this.props.todo.id)
                    }}>delete</button> */}
                    <FontAwesomeIcon
                        icon={faTrash}
                        style={{ color: 'rgb(40, 44, 52)', fontSize: '25px' }}
                        onClick={() => {
                            this.props.deleteTodo(this.props.todo.id)
                        }}
                    />
                </div>
            </div>
        );
    }
}

export default Todo;