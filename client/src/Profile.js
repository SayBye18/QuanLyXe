import React from 'react'
import { useSelector } from 'react-redux'
// hàm
// props ( properties ) là 1 object

const Profile = (props) => {

    const { indexColor } = useSelector(state => state.App)

    return (
        <div className="profile-item" style={{ backgroundColor: indexColor, marginBottom: "20px", color: "white" }}>
            {props.id} : {props.name}
        </div>
    )
}

export default Profile
