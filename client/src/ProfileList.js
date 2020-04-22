import React from 'react'
import { useSelector } from 'react-redux'
import Profile from './Profile'

const ProfileList = () => {

    const { arr } = useSelector(state => state.App)

    return (
        <div>
            {
                arr.map(val => <Profile id={val.id} name={val.name} key={val.id} />)
            }
        </div>
    )
}

export default ProfileList
