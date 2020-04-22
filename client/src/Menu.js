import React, { useState, useEffect } from 'react'
import { changeColor } from './Redux/Actions/App'
import { useDispatch } from 'react-redux'

const Menu = () => {

    const [name, setName] = useState("");

    const dispatch = useDispatch();

    const handleClick = (event) => {

    }

    const handleChange = (event) => {
        setName(event.target.value)
    }

    const changeColorMenu = () => {
        dispatch(changeColor(name));
    }

    return (
        <div>
            <button onClick={handleClick} >Click me</button>
            <input type="text" value={name} onChange={handleChange} />
            <button onClick={changeColorMenu} >Change Color</button>
        </div>
    )
}

export default Menu
